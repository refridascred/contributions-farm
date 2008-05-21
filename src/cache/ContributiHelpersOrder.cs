using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long bound)
        {
            if ((bound + 309) >= (floor % 60))
            {
                return 4;
            }
            else
            {
                if (((double)bound == (1.5 / 4.0)) && (1 <= bound))
                {
                    return 2;
                }
                else
                {
                    if (((-1) * 2) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound / 5) >= floor) && ((double)floor < (5.93 + 8.28)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Locked,
            Idle,
            New,
            Pending,
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool VerifyProfileWindowLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
