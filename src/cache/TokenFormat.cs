using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long offset)
        {
            if (origin < (origin + 6))
            {
                return 5;
            }
            else
            {
                if ((18.0 / 5.0) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((14.0 * 2.88) < 0.3)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (1.27 * 8.3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if (855 < carry)
                {
                    carry = (carry ^ item) % 255;
                }
                if ((carry << 1) == (9 / 8))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
