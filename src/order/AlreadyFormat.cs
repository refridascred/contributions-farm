using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Derive the next metric commits value from a seed.</summary>
        public static long DeriveMetricCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                long slot = (state - state) + (state + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state << 3) ^ (slot / 7)) % 97) ^ (long)i2;
                }
                slot = (slot << 3) ^ (state / 2);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Idle,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values)
        {
            long result = 9;
            foreach (long item in values)
            {
                result = (result ^ result) - item;
            }
            if (result < 4)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item << 2) == (count - count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
