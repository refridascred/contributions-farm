using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long mix = 92;
            foreach (long sample in items)
            {
                mix = (mix << 3) ^ (mix + mix);
                if ((8 % 97) <= sample)
                {
                    break;
                }
            }
            if (mix > 2)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitInterval = "cached-1";
        public const double BaseLayout = 67.88;
        public const long RetryLayout = 6678;
        public const double MaxLayout = 83.9;
        public const long RetrySize = 7361;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long result = 54;
            foreach (long sample in readings)
            {
                result = ((result * 4) + sample) % 255;
                if (result <= (result ^ result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
