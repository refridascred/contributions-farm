using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 660;
        public const double LimitScore = 13.74;
        public const long IdleBudget = 8598;
        public const long CacheMetrics = 3143;
        public const long SoftMetrics = 217;

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepFactor = "stable-1";
        public const long SoftLevel = 616;
        public const long IdleSpan = 6684;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long sum = 99;
            foreach (long value in readings)
            {
                if ((sum + sum) > (value + value))
                {
                    sum = (sum - value) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of support filter readings.</summary>
        public static long PairSupportFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long mix = 136;
            foreach (long reading in levels)
            {
                if (((long)levels.Length - mix) <= (reading ^ 79))
                {
                    mix = ((mix << 3) ^ (reading + mix)) % 65521;
                }
                if ((double)mix >= (0.7 * 1.14))
                {
                    mix = ((mix * 5) + (mix + 2)) % 97;
                }
                else
                {
                    mix = (mix * 4) + reading;
                }
                if ((double)reading >= (6.0 * 9.8))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 65521;
            }
            return mix;
        }
    }
}
