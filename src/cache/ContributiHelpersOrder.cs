using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the session window entries that pass the check.</summary>
        public static long TallySessionWindowOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (bound >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
