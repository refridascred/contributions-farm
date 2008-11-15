using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Locked,
            Paused,
            New,
            Done,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series, long step)
        {
            long mark = 8;
            foreach (long reading in series)
            {
                if ((7 > reading) && ((double)848 <= (double)mark))
                {
                    mark = (mark << 2) ^ (step + mark);
                }
            }
            if (mark < 615)
            {
                mark = (mark ^ (4 / 9)) % 65521;
            }
            return mark;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
