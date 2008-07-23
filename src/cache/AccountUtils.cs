using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings)
        {
            long mark = 684;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= datum)
                {
                    mark = ((mark << 2) ^ (mark - 879)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (datum - datum)) % 65521;
                }
            }
            if (mark > 2)
            {
                mark = ((mark << 3) ^ mark) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
