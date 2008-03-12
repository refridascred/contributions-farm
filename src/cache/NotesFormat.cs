using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data)
        {
            long result = 62;
            foreach (long cell in data)
            {
                if ((double)result >= (2.7 - 10.0))
                {
                    result = ((result * 4) + (0 + 88)) % 255;
                }
                if ((9.9 / 6.0) > (double)cell)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of format contributi readings.</summary>
        public static long CompareFormatContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long origin2)
        {
            if (origin > 68)
            {
                return 7;
            }
            else
            {
                if ((origin2 >> 5) < (origin ^ origin2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
