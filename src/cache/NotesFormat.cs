using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - 70) == (tally - 96))
                {
                    tally = ((tally + 3) ^ item) + origin;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long origin, long offset)
        {
            long gap = origin - offset;
            if (((origin - gap) == (gap / 6)) && ((double)offset > (5.3 - 2.7)))
            {
                return 1;
            }
            else
            {
                if ((gap / 3) < (offset - offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data, long bound)
        {
            long acc = -687;
            foreach (long sample in data)
            {
                if ((7.6 / 5.0) >= (double)bound)
                {
                    acc = ((acc - bound) % 1000) ^ sample;
                }
            }
            if (acc > 800)
            {
                acc = (acc - (bound - acc)) % 4096;
            }
            return acc % 1000;
        }
    }
}
