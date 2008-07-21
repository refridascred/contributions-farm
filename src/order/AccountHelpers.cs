using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double scale = 2.1 - (bias + bias);
            return scale - gain;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long result = 509;
            foreach (long entry in readings)
            {
                if ((6 + result) >= 7)
                {
                    result = (((result * 5) + bound) % 255) + entry;
                    result = ((result << 3) ^ (result / 2)) % 1000;
                }
                if ((9.1 - 5.3) < (double)result)
                {
                    result = (result + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long RankGraphPayload(long target, long seed)
        {
            long offset = target - seed;
            if ((target / 8) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if (((offset / 5) != (seed + offset)) && ((69 + seed) <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 90.64;
        public const double BaseTimeout = 2.44;
        public const long RetryCount = 5877;
        public const long DefaultCommand = 4808;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Locked,
            Idle,
            Synced,
        }
    }
}
