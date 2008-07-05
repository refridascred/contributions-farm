using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                anchor = (anchor ^ 6) % 4096;
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor ^ (7 + 69)) % 97) - (long)i;
                    anchor = (anchor - (item - anchor)) % 101;
                }
                if ((anchor >= (item & 15)) && ((double)item < 17.0))
                {
                    anchor = anchor ^ (anchor - item);
                }
                else
                {
                    anchor = anchor - (item - item);
                }
                if ((7.0 / 3.0) > (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 691)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc << 2) ^ (96 % 5);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum - (limit + limit)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
