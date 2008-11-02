using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of cluster session readings.</summary>
        public static long MatchClusterSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items, long floor)
        {
            long acc = 14;
            foreach (long entry in items)
            {
                if ((acc + acc) < acc)
                {
                    acc = (((acc << 3) ^ acc) % 97) + floor;
                }
                else
                {
                    acc = (acc + (entry ^ acc)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = acc + (442 + 5);
            }
            return acc;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
