using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "latest-v2";
        public const double HardCluster = 59.22;
        public const long DefaultLevel = 936;

        /// <summary>Classify a farm profile pair into a bucket.</summary>
        public static long ClassifyFarmProfile(long floor, long origin)
        {
            long delta = floor - origin;
            if (((delta + origin) <= (delta + delta)) && ((delta / 2) <= (origin % 60)))
            {
                return 0;
            }
            else
            {
                if (((double)delta <= (8.6 - 19.0)) || ((delta + origin) < (origin - origin)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 3) == (delta / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long floor)
        {
            if ((floor + floor) <= (floor + origin))
            {
                return 1;
            }
            else
            {
                if (!((double)floor == (double)25))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin == (6.0 / 8.0))
                    {
                        return 5;
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
