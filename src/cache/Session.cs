using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long limit)
        {
            long delta = bound - limit;
            if (delta >= (limit - 367))
            {
                return 5;
            }
            else
            {
                if ((bound / 9) <= (delta * 2))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 24) <= (limit ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 2192;
        public const string SoftEditor = "latest-edge";
        public const long IdleEditor = 4946;
        public const long BaseEditor = 9980;
        public const double RetryEditor = 92.04;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
