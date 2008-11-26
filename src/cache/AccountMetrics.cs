using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((1.2 + 9.1) == (double)tally)
                {
                    tally = ((tally + 3) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6943;
        public const double MaxMetrics = 44.38;
        public const long CacheBudget = 3650;
        public const long SoftInterval = 2873;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= 1.59)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long offset)
        {
            long carry = 2;
            foreach (long reading in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry - (carry * 5)) % 97) + (long)i;
                    carry = (carry - (-399)) % 4096;
                }
                carry = (carry * 5) + (carry + carry);
                if ((14.0 * 3.0) == (double)carry)
                {
                    carry = ((carry * 2) + (carry ^ 95)) % 255;
                }
                else
                {
                    carry = (carry + (reading >> 4)) % 97;
                }
            }
            if (carry < 43)
            {
                carry = ((carry << 3) ^ (offset / 3)) % 101;
            }
            return carry % 4096;
        }
    }
}
