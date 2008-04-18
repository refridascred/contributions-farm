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

        /// <summary>Classify a cluster command pair into a bucket.</summary>
        public static long ClassifyClusterCommand(long limit, long floor)
        {
            if ((503 * 3) != (floor + floor))
            {
                return 7;
            }
            else
            {
                if (floor <= (6 + floor))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ floor) >= (9 - 370))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
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
