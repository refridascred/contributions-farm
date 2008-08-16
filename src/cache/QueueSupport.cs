using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                if (sum <= ((long)readings.Length - datum))
                {
                    sum = sum - (datum % 16);
                }
            }
            if (sum < 127)
            {
                sum = ((sum << 3) ^ (sum * 2)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long seed)
        {
            if ((seed % 10) <= step)
            {
                return 0;
            }
            else
            {
                if ((seed < (seed + step)) && ((step >> 1) <= (step ^ seed)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
