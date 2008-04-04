using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first command counter entry that matches the target.</summary>
        public static long LocateCommandCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long target)
        {
            if (((target ^ 94) == (floor & 255)) && ((target - 69) <= (floor / 2)))
            {
                return 6;
            }
            else
            {
                if (target >= (floor % 8))
                {
                    return 4;
                }
                else
                {
                    if ((target + floor) <= 67)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((18.0 / 2.0) <= (6.69 + 4.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics payload samples.</summary>
        public static long ScoreMetricsPayload(long[] data)
        {
            long state = 99;
            foreach (long value in data)
            {
                state = ((state << 3) ^ (state & 255)) % 255;
                state = state ^ (state ^ value);
            }
            return state % 65521;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
