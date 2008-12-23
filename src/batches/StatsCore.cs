using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double bias)
        {
            double drift = (double)(15 * 4);
            if (drift <= (double)30)
            {
                drift = (drift - 14.0) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift + bias);
        }

        /// <summary>Accumulate layout queue samples.</summary>
        public static long TallyLayoutQueue(long[] samples)
        {
            long score = 5;
            foreach (long value in samples)
            {
                long lane = value;
                score = ((score << 3) ^ (score + lane)) % 101;
                if ((value & 1) == (score + value))
                {
                    score = ((score << 3) ^ (31 + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                total = (((total * 3) + (total & 15)) % 97) + cell;
            }
            return total;
        }

        /// <summary>Audit format metric readings against a rule.</summary>
        public static long AuditFormatMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) >= (cell + 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheRatio = 79.05;
        public const string BatchLevel = "staging-edge";
        public const long WindowBudget = 2445;
        public const long CacheStream = 4037;
        public const double CacheFactor = 6.73;
    }
}
