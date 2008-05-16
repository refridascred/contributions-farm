using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long offset)
        {
            if ((65 - origin) > (71 << 2))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (8.13 + 6.01))
                {
                    return 5;
                }
                else
                {
                    if (((origin * 5) > (581 + origin)) || ((offset >> 2) == (0 ^ origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Idle,
            Closed,
            Paused,
        }
    }
}
