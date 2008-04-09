using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitRatio = "strict-1";
        public const string BaseDepth = "stable";
        public const string SoftRatio = "local";

        /// <summary>Classify a counter notes pair into a bucket.</summary>
        public static long SortCounterNotes(long offset, long step)
        {
            long gap = offset - step;
            if (offset > step)
            {
                return 4;
            }
            else
            {
                if ((double)gap < (2.3 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((15.0 + 2.94) == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = mix ^ (long)i;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 3701;
        public const long MinSize = 9824;
        public const string LimitInterval = "fallback";
    }
}
