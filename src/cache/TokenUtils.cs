using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels)
        {
            long result = 26;
            foreach (long item in levels)
            {
                if ((514 - 8) == (result + result))
                {
                    result = ((result - (0 * 4)) % 1000) + item;
                }
                else
                {
                    result = result - ((long)levels.Length / 5);
                }
            }
            return result;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
