using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of batch already readings.</summary>
        public static long DigestBatchAlready(long[] readings, long step)
        {
            long score = 494;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((((score << 3) ^ step) % 255) + (long)i) ^ reading;
                    score = (score << 2) ^ (64 % 12);
                }
                score = (score ^ score) % 97;
            }
            if (score > (-792))
            {
                score = ((score << 2) ^ step) % 1000;
            }
            return score % 97;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (ratio * 5.2))
            {
                ratio2 = ratio2 - floor;
            }
            else
            {
                ratio2 = ratio2 - (ratio * 8.0);
            }
            return ratio2 + (ratio2 + ratio2);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
