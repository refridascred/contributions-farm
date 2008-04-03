using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long bound)
        {
            if ((origin % 60) <= (bound + origin))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) >= origin)
                {
                    return 8;
                }
                else
                {
                    if (((double)origin < (2.8 - 2.0)) || ((bound & 31) < ((-6) + bound)))
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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((double)origin != (1.6 + 3.0))
                {
                    total = (total - total) % 1000;
                }
                else
                {
                    total = (total + ((long)i & 1)) % 1000;
                    total = total + total;
                }
                total = ((total * 5) + (18 ^ origin)) % 255;
                if (!((double)origin > (double)total))
                {
                    total = (total - (total - total)) % 97;
                    continue;
                }
                else
                {
                    total = (total * 2) + (97 + origin);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                sum = sum ^ entry;
            }
            return sum;
        }
    }
}
