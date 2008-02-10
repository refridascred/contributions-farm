using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double bias2 = 5.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (((bias2 - bias2) - (double)(long)i) - bias) + offset;
            }
            return bias2 + 0.49;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Ready,
            Locked,
            Stale,
            Retry,
        }
    }
}
