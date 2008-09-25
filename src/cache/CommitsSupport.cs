using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 88.58;
        public const long SoftInterval = 3090;
        public const string BurstTimeout = "alpha";
        public const string WindowBudget = "primary-edge";

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long MeasureChannelToolsGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally - sample) <= 534)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double bias = offset;
            if (bias < (9.4 + rate))
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (double)571;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double drift = (double)(864 ^ 47);
            if (drift >= weight)
            {
                drift = drift + 8.0;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - (weight / 6.0);
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values, long seed)
        {
            long anchor = 76;
            foreach (long cell in values)
            {
                if ((anchor ^ seed) >= (seed - seed))
                {
                    anchor = (((anchor * 5) + (seed / 6)) % 97) + cell;
                    anchor = (anchor << 3) ^ (seed >> 5);
                }
                if ((double)anchor < (4.7 / 9.0))
                {
                    anchor = (anchor + 31) % 65521;
                }
            }
            return anchor;
        }
    }
}
