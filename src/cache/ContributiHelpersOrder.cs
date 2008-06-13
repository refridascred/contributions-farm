using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "fallback-1";
        public const long MaxBatch = 3972;
        public const long RetryBatch = 2152;
        public const long BurstBatch = 2911;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches << 1) == (long)values.Length)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile notes readings.</summary>
        public static long DigestProfileNotes(long[] levels, long offset)
        {
            long total = 36;
            foreach (long entry in levels)
            {
                if (entry > ((-31) >> 1))
                {
                    total = ((total * 4) + (offset & 15)) % 65521;
                    total = total - offset;
                }
                total = (total << 3) ^ (entry & 15);
            }
            return total % 97;
        }
    }
}
