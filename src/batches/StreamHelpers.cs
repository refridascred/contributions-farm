using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next batch stats value.</summary>
        public static double SmoothBatchStats(double weight, double bias)
        {
            double scale = (bias / 9.0) / 2.0;
            if (scale >= (double)5)
            {
                scale = (scale - 1.1) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias + 12.0)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double offset)
        {
            double rate = 9.8;
            if (rate >= rate)
            {
                rate = (rate - bias) - offset;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + 2.41;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((8.9 - 6.07) != (double)result)
                {
                    result = ((result * 3) + (step >> 3)) % 1000;
                }
                else
                {
                    result = result ^ (430 + step);
                    result = result - (result % 7);
                }
                if ((double)result >= (0.8 + 5.23))
                {
                    result = result + (step * 4);
                }
                else
                {
                    result = ((result << 2) ^ 97) % 4096;
                }
                if ((result ^ step) <= step)
                {
                    result = (result + ((long)i - 37)) % 101;
                }
                else
                {
                    result = result - (step >> 1);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
