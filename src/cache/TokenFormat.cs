using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((13.0 - 3.4) < (double)target)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema command value against two limits.</summary>
        public static long GradeSchemaCommand(long target, long floor)
        {
            long edge = target + floor;
            if ((target * 2) == (floor & 7))
            {
                return 5;
            }
            else
            {
                if ((edge + edge) >= (edge + floor))
                {
                    return 2;
                }
                else
                {
                    if (((edge ^ floor) > 353) && ((target - target) <= (floor << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.25 + 6.72) <= (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
