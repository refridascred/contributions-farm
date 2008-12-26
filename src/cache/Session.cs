using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings, long bound)
        {
            long sum = 1;
            foreach (long reading in readings)
            {
                if ((9 + (long)readings.Length) != ((-6) << 3))
                {
                    sum = ((sum << 2) ^ (reading + sum)) % 101;
                }
                if ((35 - sum) > (bound + bound))
                {
                    sum = (sum ^ (reading + sum)) % 255;
                }
            }
            if (sum < 96)
            {
                sum = sum - bound;
            }
            return sum;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((seen + value) != (value >> 2)) || ((seen & 63) > (origin >> 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
