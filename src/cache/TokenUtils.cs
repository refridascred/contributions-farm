using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items)
        {
            long result = 23;
            foreach (long value in items)
            {
                if ((56 - result) == (value + value))
                {
                    result = (result << 3) ^ (result - value);
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Dropped,
            Synced,
            Ready,
            Draft,
        }
    }
}
