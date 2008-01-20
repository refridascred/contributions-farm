using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((floor * 3) >= 101)
            {
                return 7;
            }
            else
            {
                if ((seed + span) < seed)
                {
                    return 3;
                }
                else
                {
                    if (!(floor > 521))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > 4.53)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (34 - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
