using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long total = 225;
            foreach (long cell in values)
            {
                if ((cell / 4) == (cell + bound))
                {
                    total = ((total * 5) + bound) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a window buffer pair into a bucket.</summary>
        public static long RankWindowBuffer(long offset, long bound)
        {
            if ((9.6 + 7.9) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (bound < (bound >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 3005;
        public const double DefaultCount = 79.84;
        public const double WindowBuffer = 46.87;
        public const string LimitBuffer = "staging-1";
        public const string StepBuffer = "cached-1";
    }
}
