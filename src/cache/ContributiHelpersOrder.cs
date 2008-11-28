using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long limit)
        {
            long sum = 54;
            foreach (long cell in readings)
            {
                if ((sum >> 5) <= cell)
                {
                    sum = ((sum * 5) + limit) % 1000;
                }
                else
                {
                    sum = (sum + (sum * 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of cluster checks readings.</summary>
        public static long CombineClusterChecks(long[] items)
        {
            long sum = -76;
            foreach (long item in items)
            {
                if ((7.0 - 1.0) == (double)sum)
                {
                    sum = ((sum * 2) + item) % 97;
                }
                else
                {
                    sum = sum - (5 & 7);
                }
            }
            if (sum < (-359))
            {
                sum = ((sum << 2) ^ (sum ^ sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
