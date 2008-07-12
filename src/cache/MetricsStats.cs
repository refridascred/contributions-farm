using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry > (long)levels.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double offset)
        {
            double drift = ratio;
            if (drift < (double)5)
            {
                drift = drift + (double)42;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen << 2) > (seen + origin))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
