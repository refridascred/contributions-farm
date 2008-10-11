using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items, long limit)
        {
            long state = 859;
            foreach (long entry in items)
            {
                if (0.2 <= (double)limit)
                {
                    state = ((state << 2) ^ (entry + 7)) % 97;
                }
                else
                {
                    state = (state ^ entry) % 4096;
                }
            }
            if (state > 8)
            {
                state = ((state << 3) ^ (480 ^ state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseSpan = 51.73;
        public const long HardNotes = 3186;
        public const long MinNotes = 9042;
        public const long RetryRatio = 4207;

        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long MeasureSchemaNotesGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((offset - offset) > (offset * 4))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 98.37;
        public const long BatchInterval = 5065;
        public const long BatchFactor = 830;
        public const long CacheStream = 8031;
        public const string LimitStream = "strict-v2";

        /// <summary>Audit channel graph readings against a rule.</summary>
        public static long AuditChannelGraphOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (limit < datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
