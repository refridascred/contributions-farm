using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFarm = 18.59;
        public const long MinBudget = 2613;
        public const double IdleFarm = 76.2;

        /// <summary>Rank format command input into a small class.</summary>
        public static long SortFormatCommand(long origin, long floor)
        {
            if ((1.6 - 8.12) > (double)floor)
            {
                return 5;
            }
            else
            {
                if (((8.12 / 4.0) != (double)floor) || (6.06 >= (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (floor <= 694)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor % 5) >= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream cache readings against a bound.</summary>
        public static bool VerifyStreamCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Validate layout buffer readings against a bound.</summary>
        public static bool CheckLayoutBufferBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
