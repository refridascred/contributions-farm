using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up context command samples.</summary>
        public static long CompareContextCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics context value against two limits.</summary>
        public static long ClassifyMetricsContext(long origin, long step)
        {
            long cur = origin - step;
            if ((origin >= (origin / 7)) || ((double)cur > (8.5 - 1.0)))
            {
                return 4;
            }
            else
            {
                if (((cur + cur) < (7 / 9)) || ((step - 8) < (23 - origin)))
                {
                    return 1;
                }
                else
                {
                    if ((origin >= step) && ((double)cur == (5.0 * 7.25)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double load = span - (double)9;
            if (load < span)
            {
                load = (load + (load + span)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(-6)) + (double)(long)i;
            }
            return load + (7.0 / 6.0);
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long state = 29;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (sample ^ state)) % 101;
            }
            if (state < 13)
            {
                state = ((state << 3) ^ (state & 127)) % 255;
            }
            return state;
        }
    }
}
