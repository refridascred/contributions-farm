using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TotalEditorCounter(long[] series, long bound)
        {
            long carry = 86;
            foreach (long sample in series)
            {
                if ((bound * 2) >= carry)
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Audit format window readings against a rule.</summary>
        public static long TallyFormatWindowHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((origin >> 1) < origin)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 3) ^ seed;
                acc = (acc + 646) % 1000;
                if ((double)acc > (19.0 + 18.0))
                {
                    acc = (acc ^ (acc << 3)) % 65521;
                    acc = acc + (acc ^ acc);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
