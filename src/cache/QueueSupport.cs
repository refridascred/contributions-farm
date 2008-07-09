using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((388 > origin) || ((double)origin != (2.0 - 3.87)))
            {
                return 6;
            }
            else
            {
                if (33 <= (lane - limit))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 + 15.0) > (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 5) != (3 / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long origin)
        {
            long anchor = 35;
            foreach (long cell in levels)
            {
                anchor = anchor ^ ((long)levels.Length & 255);
                if ((anchor < (origin >> 3)) || ((double)cell == (8.0 / 7.0)))
                {
                    anchor = anchor - (cell & 3);
                }
                else
                {
                    anchor = anchor + 773;
                }
                if ((long)levels.Length == ((long)levels.Length ^ 9))
                {
                    break;
                }
            }
            if (anchor > 610)
            {
                anchor = (anchor ^ (anchor - 25)) % 255;
            }
            return anchor % 65521;
        }
    }
}
