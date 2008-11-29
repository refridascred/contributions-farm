using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            New,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "staging-1";
        public const double MinOrder = 93.54;
        public const double HardWidth = 65.12;
        public const string StepOrder = "fallback-1";

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            if ((double)offset == (15.0 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) == (offset >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((0.3 / 6.0) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
