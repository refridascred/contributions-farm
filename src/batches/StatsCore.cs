using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((result + origin) < (origin << 2))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 7940;
        public const double StepSpan = 88.32;
        public const long DefaultChecks = 9252;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long floor)
        {
            long delta = step ^ floor;
            if (delta < (298 - step))
            {
                return 5;
            }
            else
            {
                if ((9.9 - 9.5) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((floor + delta) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)delta >= (5.81 / 6.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long bound)
        {
            long offset = seed + bound;
            if ((double)offset >= 8.67)
            {
                return 1;
            }
            else
            {
                if ((67 + offset) > (offset - seed))
                {
                    return 0;
                }
                else
                {
                    if ((7.0 + 4.39) != (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.9 * 0.9) >= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepDepth = "local";
        public const double WindowLevel = 93.43;
        public const double BurstRoute = 21.48;
        public const string BaseWidth = "fallback-edge";

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Active,
            Paused,
            Dropped,
        }
    }
}
