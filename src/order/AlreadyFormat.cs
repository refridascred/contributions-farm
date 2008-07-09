using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches << 1) > (249 + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels)
        {
            long total = -700;
            foreach (long item in levels)
            {
                if ((total * 3) >= (item - total))
                {
                    total = (total << 2) ^ (item >> 3);
                }
                else
                {
                    total = total - (item << 2);
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((value >> 4) < 5))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Idle,
            Active,
            Ready,
            Queued,
        }
    }
}
