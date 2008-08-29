using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph commits samples are out of range.</summary>
        public static long AuditGraphCommitsMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((seen - target) > seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Failed,
            Draft,
        }
    }
}
