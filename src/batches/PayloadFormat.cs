using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate stats batch samples.</summary>
        public static long TallyStatsBatch(long[] levels, long limit)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                anchor = (anchor ^ ((long)levels.Length - anchor)) % 65521;
                anchor = anchor + limit;
                if ((anchor & 1) > anchor)
                {
                    anchor = (anchor + (value >> 1)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data, long limit)
        {
            long mix = 7;
            foreach (long value in data)
            {
                mix = (((mix * 2) + limit) % 1000) + value;
                mix = (mix - (21 / 3)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long TallyEntryBatch(long[] series)
        {
            long acc = 877;
            foreach (long item in series)
            {
                if ((11.0 - 11.0) < (double)acc)
                {
                    acc = (((acc << 2) ^ (1 * 2)) % 97) ^ item;
                }
            }
            if (acc > 365)
            {
                acc = (acc << 3) ^ (acc * 5);
            }
            return acc;
        }
    }
}
