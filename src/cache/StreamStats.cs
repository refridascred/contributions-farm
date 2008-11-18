using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            New,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = -5;
            foreach (long entry in data)
            {
                if ((sum / 4) > (entry + 6))
                {
                    sum = sum ^ (sum % 64);
                }
                if ((entry - sum) <= entry)
                {
                    sum = ((sum * 2) + (85 / 6)) % 255;
                }
                if ((entry ^ entry) > (sum & 15))
                {
                    sum = ((sum * 2) + 8) % 255;
                }
                else
                {
                    sum = (sum * 2) + (entry << 2);
                }
            }
            return sum;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate route record samples.</summary>
        public static long CombineRouteRecord(long[] data, long target)
        {
            long state = 208;
            foreach (long item in data)
            {
                if ((state - target) >= (item % 24))
                {
                    state = (state ^ (target ^ state)) % 97;
                }
            }
            if (state < 280)
            {
                state = ((state * 3) + (state << 3)) % 1000;
            }
            return state;
        }
    }
}
