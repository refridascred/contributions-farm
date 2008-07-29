using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next commits report value from a seed.</summary>
        public static long StepCommitsReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i / 7) > (carry + seed))
                {
                    carry = (carry ^ (913 - seed)) % 4096;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long offset)
        {
            long bound = target + offset;
            if ((3.9 * 3.6) > (double)target)
            {
                return 8;
            }
            else
            {
                if ((target + bound) == (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if (target < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Dropped,
            Closed,
        }
    }
}
