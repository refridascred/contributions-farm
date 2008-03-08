using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((5.81 / 6.0) != (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine stats schema values into a single score.</summary>
        public static long TallyStatsSchema(long[] readings)
        {
            long acc = 5;
            foreach (long reading in readings)
            {
                acc = acc - reading;
                if ((reading - reading) > reading)
                {
                    acc = (acc ^ reading) % 1000;
                    acc = (acc << 2) ^ (reading - reading);
                    break;
                }
                acc = ((acc * 5) + reading) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5783;
        public const long BatchEditor = 8861;
        public const long BaseEditor = 4721;
        public const long LimitSize = 3253;
        public const long MinEditor = 6710;
    }
}
