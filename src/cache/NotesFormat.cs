using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Combine command record values into a single score.</summary>
        public static long TallyCommandRecord(long[] levels, long bound)
        {
            long sum = 727;
            foreach (long datum in levels)
            {
                if ((9 >> 2) != (datum - bound))
                {
                    sum = ((sum * 2) + ((long)levels.Length & 7)) % 65521;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + (903 * 5)) + (long)i;
                }
                if ((double)sum != (1.0 + 3.53))
                {
                    sum = (sum + ((long)levels.Length - datum)) % 65521;
                }
            }
            if (sum > 4)
            {
                sum = ((sum * 5) + (bound << 3)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Idle,
            Synced,
        }
    }
}
