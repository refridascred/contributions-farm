using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long offset)
        {
            long state = 84;
            foreach (long value in readings)
            {
                state = (((state * 5) + ((long)readings.Length % 12)) + value) + offset;
            }
            if (state < 15)
            {
                state = (state ^ (state >> 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
