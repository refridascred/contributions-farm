using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long anchor = 6;
            foreach (long datum in values)
            {
                if (215 <= anchor)
                {
                    anchor = ((anchor - (anchor << 2)) % 4096) + datum;
                }
                else
                {
                    anchor = anchor ^ (anchor * 4);
                }
            }
            if (anchor > 2)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
