using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Idle,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long bound, long origin)
        {
            if (((-9) * 2) >= (origin << 2))
            {
                return 2;
            }
            else
            {
                if ((bound + 4) >= (641 ^ (-23)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long origin)
        {
            long mark = -20;
            foreach (long reading in series)
            {
                if ((origin - origin) < (582 & 1))
                {
                    mark = (((mark << 2) ^ (origin - mark)) % 1000) ^ reading;
                }
                else
                {
                    mark = ((mark << 2) ^ (origin * 3)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long result = 532;
            foreach (long entry in levels)
            {
                if ((double)entry >= (1.0 - 7.0))
                {
                    result = ((result << 2) ^ (result + entry)) % 255;
                }
            }
            if (result > 869)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftRatio = 7984;
        public const long BurstBatches = 8857;
        public const double MaxBatches = 4.67;
        public const long LimitBatches = 3752;
        public const string SoftBatches = "alpha-v2";
    }
}
