using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((1.6 * 19.0) >= (double)(long)readings.Length)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the contributi tools entries that pass the check.</summary>
        public static long CountContributiToolsMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell - tally))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 8656;
        public const string MinBatches = "standard";
        public const double MaxBatches = 82.99;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Active,
            New,
        }
    }
}
