using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples, long floor)
        {
            long carry = 151;
            foreach (long cell in samples)
            {
                carry = ((carry + (cell << 3)) % 1000) + floor;
            }
            return carry;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Ready,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double rate = floor - (floor - ratio);
            if (rate > (rate * 4.66))
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (ratio + floor);
            }
            return rate - (9.8 - ratio);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)matches > 3.0))
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
