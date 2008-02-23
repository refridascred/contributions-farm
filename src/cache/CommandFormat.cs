using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long bound = floor + limit;
            if ((limit << 3) < (bound >> 5))
            {
                return 1;
            }
            else
            {
                if (((floor - floor) == (floor + limit)) && ((1.26 - 3.3) != (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((limit - 34) < (bound - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7129;
        public const double DefaultInterval = 86.95;
        public const double WindowContributi = 9.27;
        public const string DefaultContributi = "cached";
        public const double StepContributi = 80.04;
    }
}
