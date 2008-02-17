using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a account contributi counter forward.</summary>
        public static long SeriesAccountContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor ^ (seed + anchor)) % 101;
                if ((seed + 63) >= anchor)
                {
                    anchor = (anchor * 4) + (anchor + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = mark - (mark - 1);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
