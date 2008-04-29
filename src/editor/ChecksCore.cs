using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSpan = 1674;
        public const long MaxChannel = 7406;
        public const long HardWidth = 1447;
        public const long RetryChannel = 8329;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                long next = (target / 5) % 97;
                next = ((next << 3) ^ acc) % 97;
                acc = (acc << 3) ^ ((-98) - next);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a profile commits reading by value.</summary>
        public static long FindProfileCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
