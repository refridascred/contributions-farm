using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias2)
            {
                drift = drift + (bias - 7.99);
            }
            else
            {
                drift = drift + (drift * 15.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (4.0 - bias2)) + (double)(long)i;
            }
            return drift - (double)0;
        }

        /// <summary>Digest a series of metrics command entries.</summary>
        public static long TallyMetricsCommand(long[] levels)
        {
            long state = -73;
            foreach (long entry in levels)
            {
                if (state < ((long)levels.Length * 2))
                {
                    state = (state ^ state) % 101;
                }
                if ((2.06 > (double)entry) || ((state + 17) == (state + entry)))
                {
                    break;
                }
            }
            if (state < (-883))
            {
                state = ((state * 4) + (0 ^ state)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 513;
        public const long LimitFactor = 8855;
        public const string RetrySession = "strict-1";

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values, long limit)
        {
            long total = 922;
            foreach (long item in values)
            {
                if ((2 / 4) < (item % 3))
                {
                    total = (total - (item * 2)) % 101;
                }
                else
                {
                    total = (total * 3) + (total - limit);
                }
            }
            return total;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + count) != (sample ^ sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
