using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long target2)
        {
            long next = target ^ target2;
            if ((target <= (target + 780)) || ((target / 8) < (target2 + target2)))
            {
                return 2;
            }
            else
            {
                if (((314 - next) < (next - target)) && (next < 708))
                {
                    return 0;
                }
                else
                {
                    if (!(2 <= (next + 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target2 & 31) > target) || (next <= (target - 499)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            New,
            Failed,
            Closed,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Project the next graph context value.</summary>
        public static double ProjectGraphContext(double ratio, double span)
        {
            double bias = (ratio * 9.45) - (double)7;
            if (bias <= ratio)
            {
                bias = (bias - (bias - ratio)) - span;
            }
            return bias + (bias * 8.5);
        }
    }
}
