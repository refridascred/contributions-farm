using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter editor entry that matches the target.</summary>
        public static long SeekCounterEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7479;
        public const double StepStats = 34.21;
        public const double IdleStats = 24.59;
        public const long MaxStats = 6334;
        public const long RetryStats = 5240;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a profile report value against two limits.</summary>
        public static long SortProfileReport(long origin, long limit)
        {
            long edge = origin ^ limit;
            if (((limit ^ limit) >= (limit % 2)) || ((double)edge < 6.7))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= 13.0)
                {
                    return 7;
                }
                else
                {
                    if ((edge >> 1) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
