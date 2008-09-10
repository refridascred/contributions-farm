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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] values)
        {
            long result = 1;
            foreach (long entry in values)
            {
                if ((12.0 - 6.6) >= (double)result)
                {
                    result = (((result << 3) ^ result) % 65521) ^ entry;
                }
            }
            return result;
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
