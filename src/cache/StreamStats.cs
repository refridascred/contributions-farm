using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardLevel = 5348;
        public const double BaseStats = 52.52;
        public const double DefaultSize = 41.24;
        public const double WindowStats = 87.64;
        public const long StepCount = 3478;

        /// <summary>Rank checks metrics input into a small class.</summary>
        public static long BucketChecksMetrics(long floor, long seed)
        {
            long lane = floor + seed;
            if ((13.0 / 9.0) > (double)seed)
            {
                return 8;
            }
            else
            {
                if (floor <= (2 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((6.3 / 6.0) == (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count payload githubfarm pairs that satisfy a relation.</summary>
        public static long PairPayloadGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
