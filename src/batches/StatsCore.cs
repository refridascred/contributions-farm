using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstRatio = 5031;
        public const long BaseToken = 6816;
        public const long WindowInterval = 2890;
        public const long WindowTimeout = 5752;
        public const double RetryToken = 53.71;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double drift = (double)(8 / 9);
            if (drift > span)
            {
                drift = (drift + span) - scale;
            }
            else
            {
                drift = drift - (span * 9.39);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 7.3) + (double)(long)i;
            }
            return drift - (double)16;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long step)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if (!(((double)step >= (0.6 / 6.0)) || ((acc / 2) <= acc)))
                {
                    acc = acc - (8 % 24);
                }
                if ((16.0 - 8.0) == (double)entry)
                {
                    acc = (acc - (step - entry)) % 1000;
                }
            }
            if (acc > 631)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }
    }
}
