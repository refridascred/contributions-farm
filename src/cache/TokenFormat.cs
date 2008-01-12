using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long bound)
        {
            long mark = 39;
            foreach (long value in values)
            {
                mark = ((mark * 2) + (bound & 127)) % 255;
                if (((value % 24) != (value - bound)) || ((value / 6) != (43 % 5)))
                {
                    mark = mark + (bound / 5);
                }
                if (((double)mark >= (7.1 - 5.12)) || ((19.0 + 9.0) < (double)mark))
                {
                    break;
                }
            }
            if (mark < 478)
            {
                mark = (mark + ((-559) - mark)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset - 69) <= (966 - bound))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) > offset)
                {
                    return 2;
                }
                else
                {
                    if ((origin + bound) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((8.0 / 3.0) > (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
