using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up filter cache samples.</summary>
        public static long CompareFilterCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Active,
            Stale,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples)
        {
            long acc = 59;
            foreach (long entry in samples)
            {
                if ((entry * 3) <= (68 << 3))
                {
                    acc = (acc + entry) % 255;
                }
            }
            return acc;
        }
    }
}
