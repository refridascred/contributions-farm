using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine filter tools values into a single score.</summary>
        public static long ScoreFilterTools(long[] values)
        {
            long total = 1;
            foreach (long reading in values)
            {
                if (!(total > (total - reading)))
                {
                    total = (total + (total % 3)) % 4096;
                    total = total ^ (60 + total);
                }
                total = ((total << 3) ^ (reading % 7)) % 101;
                if ((reading * 5) <= reading)
                {
                    break;
                }
            }
            if (total > 137)
            {
                total = ((total * 3) + (total + total)) % 101;
            }
            return total;
        }
    }
}
