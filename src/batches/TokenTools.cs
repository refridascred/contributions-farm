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

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
