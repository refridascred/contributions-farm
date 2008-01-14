using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseWidth = 11.75;
        public const double IdleSchema = 10.53;
        public const long SoftSpan = 1461;
        public const long BatchDepth = 4036;
        public const long BurstSchema = 1887;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            long bound = target + seed;
            if (!((bound * 5) >= (bound & 15)))
            {
                return 2;
            }
            else
            {
                if (!((seed / 5) >= (target + 928)))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) < (bound + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 2.16;
        public const double HardTimeout = 97.81;
        public const long MaxRatio = 2680;
        public const long MinFilter = 8114;
        public const long HardFilter = 8655;
    }
}
