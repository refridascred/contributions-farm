using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "staging-v2";
        public const double IdleFilter = 42.87;
        public const long DefaultFilter = 5533;
        public const double RetryFilter = 58.12;
        public const string StepFilter = "stable-edge";

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long step, long floor)
        {
            if ((step / 7) >= (6 - floor))
            {
                return 4;
            }
            else
            {
                if ((9 / 2) <= (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) != (step + 60))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine editor tools values into a single score.</summary>
        public static long TallyEditorTools(long[] series)
        {
            long state = 83;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 - 5.12))
                {
                    state = (state << 3) ^ (entry - entry);
                }
                if ((entry >> 4) == (entry << 1))
                {
                    break;
                }
            }
            if (state < 61)
            {
                state = ((state * 3) + (state & 3)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long floor, long step)
        {
            if ((floor << 3) < step)
            {
                return 0;
            }
            else
            {
                if ((4.0 * 4.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
