using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc << 2) ^ ((long)i + 60);
                if ((bound << 3) == (bound / 4))
                {
                    acc = acc + bound;
                }
                else
                {
                    acc = (acc + (bound >> 2)) % 255;
                }
                acc = acc ^ ((long)i + acc);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of route payload readings.</summary>
        public static long PairRoutePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 3405;
        public const string SoftWidth = "latest-edge";
        public const double IdleRoute = 6.28;
        public const double IdleSize = 14.4;
        public const long MaxRoute = 7843;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
