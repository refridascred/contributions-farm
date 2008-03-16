using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally < (item / 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Closed,
            Done,
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many booking samples are out of range.</summary>
        public static long TallyBookingOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (9.05 - 5.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
