using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate support session samples.</summary>
        public static long WeighSupportSession(long[] data)
        {
            long total = 77;
            foreach (long reading in data)
            {
                total = (((total * 4) + 702) % 65521) - reading;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 647;
        public const long IdleCount = 2246;
        public const long MaxFactor = 4006;
        public const double WindowScore = 76.2;
        public const long BatchSupport = 2421;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
