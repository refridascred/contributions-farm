using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items, long target)
        {
            long anchor = 239;
            foreach (long sample in items)
            {
                anchor = ((((anchor << 2) ^ (68 + 9)) % 65521) - sample) - target;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - entry) > origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
