using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 2925;
        public const long SoftWidth = 6356;
        public const string BaseRecord = "staging-edge";
        public const string BatchRecord = "cached-1";
        public const long WindowBudget = 9152;

        /// <summary>Grade a already entry value against two limits.</summary>
        public static long SortAlreadyEntry(long target, long offset)
        {
            if (18.0 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (double)29)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double scale2 = scale * 18.0;
            if (scale2 >= (scale * 5.7))
            {
                scale2 = scale2 + (scale - 1.6);
            }
            else
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (offset - 8.1)) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Queued,
            Retry,
            Done,
        }
    }
}
