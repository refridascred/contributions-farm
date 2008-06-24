using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count > (item + (-4))) && !((9 + count) <= (count >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count token farm pairs that satisfy a relation.</summary>
        public static long PairTokenFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowDepth = "stable-edge";
        public const string HardLevel = "legacy-v2";
        public const string MinCache = "stable-1";
        public const double BatchScore = 68.8;
        public const string WindowCache = "legacy-edge";
    }
}
