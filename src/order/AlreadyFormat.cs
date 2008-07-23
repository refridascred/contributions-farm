using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long state = 32;
            foreach (long entry in readings)
            {
                state = ((state * 2) + state) % 101;
                if (!((23 + entry) > (entry % 5)))
                {
                    continue;
                }
                if ((entry ^ state) >= (state << 2))
                {
                    state = state + (entry + entry);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Ready,
            Failed,
            Queued,
            Retry,
        }

        /// <summary>Fold a list of graph window readings.</summary>
        public static long TotalGraphWindow(long[] data, long offset)
        {
            long anchor = 0;
            foreach (long item in data)
            {
                if (item < (item + 470))
                {
                    anchor = (anchor + (offset + offset)) % 255;
                }
            }
            if (anchor < 71)
            {
                anchor = anchor - (offset ^ (long)data.Length);
            }
            return anchor;
        }
    }
}
