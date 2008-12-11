using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ ((long)i - acc);
                acc = ((acc * 5) + seed) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 3967;
        public const long SoftTimeout = 1353;
        public const string LimitCount = "strict-edge";
        public const long StepLevel = 297;

        /// <summary>Match up contributi commits samples.</summary>
        public static long PairContributiCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + (905 + acc);
                acc = (acc * 2) + ((long)i >> 1);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 5433;
        public const string BaseCount = "fallback-1";
        public const long MaxBudget = 3959;
        public const string WindowBuffer = "alpha-v2";
        public const long MinBuffer = 4642;
    }
}
