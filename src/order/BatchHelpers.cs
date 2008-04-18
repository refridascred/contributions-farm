using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long offset)
        {
            long next = target + offset;
            if ((double)next != (5.0 + 8.0))
            {
                return 7;
            }
            else
            {
                if ((target / 7) > next)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long origin)
        {
            if ((limit >> 5) > limit)
            {
                return 4;
            }
            else
            {
                if (limit > (limit % 64))
                {
                    return 5;
                }
                else
                {
                    if ((78 ^ origin) < 426)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit < (15.0 / 8.0))
                        {
                            return 2;
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
}
