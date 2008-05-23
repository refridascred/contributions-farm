using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 683;
        public const string StepCluster = "local-edge";
        public const string BurstSize = "cached";
        public const long HardWidth = 6993;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long target)
        {
            if (((double)target == (7.1 + 20.0)) && (3.21 > (double)target))
            {
                return 2;
            }
            else
            {
                if (((target + target) <= (825 % 7)) || (target <= ((-747) % 3)))
                {
                    return 5;
                }
                else
                {
                    if (((seed + target) < (42 + seed)) || ((5.0 - 9.97) != (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed < (4.09 - 15.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
