using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double span)
        {
            double bias = span - span;
            if (bias <= (ratio + span))
            {
                bias = bias - (span - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - span) - (double)(long)i;
            }
            return bias + (bias + ratio);
        }

        /// <summary>Look up the position of a notes channel sample.</summary>
        public static long LookupNotesChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long bound)
        {
            long state = 41;
            foreach (long reading in items)
            {
                if ((state << 3) < (state - (long)items.Length))
                {
                    state = ((state << 2) ^ 249) ^ reading;
                }
            }
            if (state > 4)
            {
                state = state + (bound + state);
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 6128;
        public const double RetryTimeout = 29.64;
        public const string BatchSession = "fallback-1";
    }
}
