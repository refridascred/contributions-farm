using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length % 60) > (floor + seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool VerifySupportSchemaBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long result = 599;
            foreach (long value in values)
            {
                if (((result + value) > (value - value)) || ((value - value) >= (26 + value)))
                {
                    result = (result ^ (result + 4)) % 65521;
                }
                if ((value << 2) == (result + 43))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
