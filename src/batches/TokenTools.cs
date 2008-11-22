using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count token notes pairs that satisfy a relation.</summary>
        public static long PairTokenNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long offset)
        {
            long carry = 94;
            foreach (long item in data)
            {
                if ((20.0 - 19.0) == (double)(long)data.Length)
                {
                    carry = (carry - (804 * 2)) - offset;
                }
                if ((item * 3) < (item + 156))
                {
                    break;
                }
            }
            if (carry > 817)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long offset)
        {
            if ((4.1 + 20.0) < (double)step)
            {
                return 5;
            }
            else
            {
                if ((step / 4) >= (step + 86))
                {
                    return 8;
                }
                else
                {
                    if ((step > (472 >> 2)) || (step <= (step - 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - step) < offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
