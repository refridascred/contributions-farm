using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up checks profile samples.</summary>
        public static long PairChecksProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long floor)
        {
            long mark = 4;
            foreach (long datum in levels)
            {
                if ((long)levels.Length >= mark)
                {
                    mark = (mark * 2) + (mark & 255);
                    continue;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 101;
                    mark = (mark << 2) ^ (3 % 5);
                }
                if (datum < (floor + datum))
                {
                    mark = (mark * 2) + (floor & 63);
                }
            }
            return mark;
        }
    }
}
