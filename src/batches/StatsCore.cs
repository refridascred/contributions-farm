using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Stale,
            Draft,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "fallback-v2";
        public const long BatchLayout = 2454;
        public const long BatchLevel = 8857;

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data)
        {
            long sum = -70;
            foreach (long datum in data)
            {
                if (datum >= (sum << 3))
                {
                    sum = ((sum << 3) ^ datum) % 1000;
                }
                else
                {
                    sum = (sum * 4) + sum;
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 2) + sum) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
