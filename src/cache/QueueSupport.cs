using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long AuditContextFilterHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - tally) < (step + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account route samples.</summary>
        public static long WeighAccountRoute(long[] series)
        {
            long score = 63;
            foreach (long sample in series)
            {
                if ((double)score < (double)sample)
                {
                    score = ((score * 4) + (sample ^ score)) % 4096;
                }
                score = score + (score & 127);
            }
            if (score > 6)
            {
                score = ((score << 3) ^ 4) % 65521;
            }
            return score % 4096;
        }
    }
}
