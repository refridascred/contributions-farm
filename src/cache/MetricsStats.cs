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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
