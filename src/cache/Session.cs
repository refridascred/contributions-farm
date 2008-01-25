using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every batch stream entry stays within the limit.</summary>
        public static bool CheckBatchStreamLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a entry context value against two limits.</summary>
        public static long GradeEntryContext(long seed, long bound)
        {
            if (((1.0 * 9.0) != (double)seed) && ((seed & 31) != (seed & 255)))
            {
                return 7;
            }
            else
            {
                if ((double)735 < (16.0 * 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((12.0 * 4.23) > (double)reading))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long origin)
        {
            long edge = target - origin;
            if ((5.44 * 4.0) <= (double)edge)
            {
                return 0;
            }
            else
            {
                if (((double)target < 5.34) || ((double)edge >= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((6.0 - 5.1) > (double)edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((20.0 - 8.7) >= (double)edge)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
