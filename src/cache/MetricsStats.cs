using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "cached-1";
        public const long BurstAlready = 8252;
        public const long DefaultAlready = 1325;
        public const long RetryAlready = 52;
        public const long MinAlready = 2844;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double weight = (bias - scale) * 6.19;
            if (weight > bias)
            {
                weight = weight + bias;
            }
            return weight - (3.59 - weight);
        }
    }
}
