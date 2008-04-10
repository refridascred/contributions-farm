using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a counter stats reading.</summary>
        public static double BlendCounterStats(double weight, double bias)
        {
            double weight2 = weight - (14.0 / 8.0);
            if (weight2 >= 7.7)
            {
                weight2 = (weight2 - (double)276) + bias;
            }
            else
            {
                weight2 = weight2 - 8.05;
            }
            return weight2 + weight2;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long bound)
        {
            if (((double)bound >= (14.0 + 10.0)) || ((bound - target) == (bound + bound)))
            {
                return 7;
            }
            else
            {
                if ((target + bound) > bound)
                {
                    return 5;
                }
                else
                {
                    if ((868 < (bound - bound)) && ((target << 2) <= 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.1 * 4.0) == (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Paused,
            Queued,
            Active,
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
