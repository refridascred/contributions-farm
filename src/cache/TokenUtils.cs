using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long bound)
        {
            long result = 30;
            foreach (long sample in items)
            {
                if (((long)items.Length - 2) == (sample + result))
                {
                    result = (result + 9) + bound;
                }
            }
            return result;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Match up metrics contributi samples.</summary>
        public static long OverlapMetricsContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
