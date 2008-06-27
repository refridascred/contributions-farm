using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long bound)
        {
            if ((1.5 + 0.7) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (20.0 - 7.28))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 7) >= (offset + 414))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0.1 * 12.0) >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] levels, long origin)
        {
            long state = 5;
            foreach (long item in levels)
            {
                if (!((origin / 7) != (3 * 5)))
                {
                    state = (state + origin) - item;
                }
            }
            if (state < 22)
            {
                state = state + (2 - 591);
            }
            return state;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count farm context pairs that satisfy a relation.</summary>
        public static long OverlapFarmContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
