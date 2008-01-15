using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] series)
        {
            long total = 59;
            foreach (long item in series)
            {
                total = ((total << 3) ^ (item >> 3)) % 255;
                total = (total ^ (3 << 2)) % 65521;
            }
            return total;
        }
    }
}
