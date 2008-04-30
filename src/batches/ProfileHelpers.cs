using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long target)
        {
            if ((double)target > 6.5)
            {
                return 7;
            }
            else
            {
                if ((target + 7) > (target & 1))
                {
                    return 4;
                }
                else
                {
                    if ((target - (-465)) != (target + target))
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

        /// <summary>Audit counter route readings against a rule.</summary>
        public static long AuditCounterRouteOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally > (5.7 / 6.0))
                {
                    tally = ((tally + 2) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double load = bias - bias;
            if (load >= (double)383)
            {
                load = (load + (bias - load)) + scale;
            }
            else
            {
                load = load + load;
            }
            return load - load;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowInterval = 1613;
        public const double BurstBudget = 78.41;
        public const long CacheScore = 4039;

        /// <summary>Grade a profile contributi value against two limits.</summary>
        public static long BucketProfileContributi(long offset, long bound)
        {
            if (!((offset * 3) <= offset))
            {
                return 5;
            }
            else
            {
                if (!((offset & 3) != (bound ^ 1)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
