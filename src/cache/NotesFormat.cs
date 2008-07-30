using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the payload route series from a seed.</summary>
        public static long DerivePayloadRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - limit;
                if (carry <= (580 & 63))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster account sample.</summary>
        public static long SeekClusterAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
