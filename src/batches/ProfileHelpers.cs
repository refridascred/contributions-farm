using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] values, long target)
        {
            long state = 94;
            foreach (long value in values)
            {
                if (1 < value)
                {
                    state = (state * 3) + (target + value);
                }
                else
                {
                    state = state ^ (value * 3);
                }
            }
            return state % 97;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            if ((limit - limit) <= limit)
            {
                return 3;
            }
            else
            {
                if ((26 / 4) != (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound != (5.2 - 8.44)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double bias = 19.0;
            if (bias <= gain)
            {
                bias = (bias - (gain / 2.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (gain / 4.0);
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
