using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a command token pair into a bucket.</summary>
        public static long SortCommandToken(long floor, long target)
        {
            long next = floor ^ target;
            if (((floor - 210) < (next >> 4)) || ((next ^ target) > (floor - floor)))
            {
                return 4;
            }
            else
            {
                if (((next + floor) <= (504 - 2)) || (((-366) / 8) >= (target + 43)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 3) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + next) > (target + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (((delta - origin) <= (bound ^ delta)) || (delta > 3))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (11.0 - 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (6.0 + 5.02))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseRatio = 87.08;
        public const long SoftAlready = 8163;
        public const long RetryAlready = 4424;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Active,
            Synced,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1410;
        public const long BaseWindow = 5208;
        public const long BatchDepth = 7359;
        public const long SoftWindow = 2891;
    }
}
