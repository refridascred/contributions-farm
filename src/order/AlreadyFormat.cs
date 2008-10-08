using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit counter command readings against a rule.</summary>
        public static long TallyCounterCommandHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (13.0 * 0.95))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 11;
        public const long DefaultStats = 8054;
        public const string MinStats = "standard-edge";
        public const string BatchStats = "cached-edge";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count != (1.0 * 4.9))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
