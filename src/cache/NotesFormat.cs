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

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxTimeout = 8717;
        public const long SoftFactor = 9038;
        public const long WindowEntry = 7879;

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
