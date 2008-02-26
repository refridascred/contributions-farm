using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1483;
        public const long MinSupport = 3771;
        public const long StepTimeout = 9790;
        public const double BurstSupport = 63.97;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series)
        {
            long carry = 421;
            foreach (long value in series)
            {
                carry = (carry * 5) + (value << 2);
            }
            return carry;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Done,
            Closed,
            Synced,
            New,
        }

        /// <summary>Compare every pair of support entry readings.</summary>
        public static long PairSupportEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 100) >= 203)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
