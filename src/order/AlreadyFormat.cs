using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinInterval = "local";
        public const long SoftFactor = 6801;
        public const string StepBuffer = "open";
        public const string CacheBudget = "staging-1";

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if ((double)875 != (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((bound + offset) > (bound ^ 8)))
                {
                    return 0;
                }
                else
                {
                    if (offset > (bound & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.25 + 13.0) == (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - 7.5) + (double)(long)i) - rate;
            }
            return mean + (double)152;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Stale,
            Dropped,
            Retry,
            Synced,
        }
    }
}
