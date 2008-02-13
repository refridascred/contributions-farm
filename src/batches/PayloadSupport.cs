using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit session notes readings against a rule.</summary>
        public static long TallySessionNotesMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (9.2 / 6.0))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches & 3) < datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter farm entry that matches the target.</summary>
        public static long SeekFilterFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
