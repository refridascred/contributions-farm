using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long origin, long limit)
        {
            long edge = origin - limit;
            if ((origin + (-3)) != (edge ^ origin))
            {
                return 2;
            }
            else
            {
                if ((origin * 4) < 0)
                {
                    return 7;
                }
                else
                {
                    if ((limit - origin) < (46 / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of record layout entries.</summary>
        public static long TallyRecordLayout(long[] levels, long seed)
        {
            long result = 874;
            foreach (long item in levels)
            {
                if (((6.0 / 3.0) > (double)result) && ((item % 12) > 393))
                {
                    result = (result - (result >> 3)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ seed) % 101;
                }
            }
            if (result < (-606))
            {
                result = ((result << 3) ^ (seed >> 4)) % 255;
            }
            return result % 97;
        }
    }
}
