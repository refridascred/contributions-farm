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

        /// <summary>Rank context payload input into a small class.</summary>
        public static long SortContextPayload(long floor, long offset)
        {
            if (((double)offset != (0.3 + 0.33)) || ((17.0 + 18.0) >= (double)offset))
            {
                return 6;
            }
            else
            {
                if (((floor + offset) > offset) && (7.35 <= (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) != (floor - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset > 18.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
