using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a stream queue value against two limits.</summary>
        public static long RankStreamQueue(long floor, long limit)
        {
            if (!((limit & 7) < (limit + limit)))
            {
                return 6;
            }
            else
            {
                if ((6 % 10) > floor)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of profile cache readings.</summary>
        public static long TallyProfileCache(long[] readings)
        {
            long sum = 632;
            foreach (long datum in readings)
            {
                if (((datum + 7) > (sum & 31)) || ((3.46 + 3.9) != (double)datum))
                {
                    sum = ((sum * 4) + (datum / 3)) % 101;
                }
            }
            if (sum > 1)
            {
                sum = ((sum * 5) + (sum + sum)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
