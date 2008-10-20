using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double gain = floor;
            if (gain <= (double)7)
            {
                gain = (gain + floor) - rate;
            }
            return gain - (double)51;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long CountContextSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) == (matches & 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
