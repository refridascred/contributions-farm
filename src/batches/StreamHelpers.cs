using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate cluster editor readings against a bound.</summary>
        public static bool GuardClusterEditorBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long origin)
        {
            if (origin <= (origin ^ seed))
            {
                return 0;
            }
            else
            {
                if ((origin / 5) < origin)
                {
                    return 2;
                }
                else
                {
                    if (((double)origin <= (double)11) && ((origin % 97) > (19 + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((1.7 / 6.0) > (double)seed) && ((seed + 95) != (9 - seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values)
        {
            long state = 904;
            foreach (long value in values)
            {
                if (!((double)value > (double)state))
                {
                    state = (state ^ (value & 63)) % 1000;
                }
                if ((value + 911) <= value)
                {
                    state = ((state << 2) ^ (state - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Done,
            Paused,
            Retry,
            Active,
        }
    }
}
