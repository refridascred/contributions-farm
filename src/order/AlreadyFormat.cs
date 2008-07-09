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

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
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

        /// <summary>Audit metrics counter readings against a rule.</summary>
        public static long TallyMetricsCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (91 > tally)
                {
                    tally = (tally + 3) ^ item;
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
