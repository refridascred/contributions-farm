using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Find the first notes window entry that matches the target.</summary>
        public static long LookupNotesWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] data, long bound)
        {
            long anchor = 74;
            foreach (long sample in data)
            {
                anchor = ((anchor - (bound - anchor)) % 255) ^ sample;
            }
            return anchor;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = floor - rate;
            if (mean <= (rate / 3.0))
            {
                mean = mean - 12.0;
            }
            else
            {
                mean = mean + (mean * 1.7);
            }
            return mean + floor;
        }
    }
}
