using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen == (9.45 / 8.0))
                {
                    seen = ((seen + 3) + cell) + limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long TallyBufferStats(long[] data)
        {
            long anchor = 173;
            foreach (long datum in data)
            {
                anchor = (anchor - 26) % 4096;
                if (datum < (anchor - datum))
                {
                    break;
                }
            }
            if (anchor > 65)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((78 % 5) <= (edge + edge))
            {
                return 1;
            }
            else
            {
                if (!(3.53 <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (!((limit2 % 7) >= edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((7.0 - 9.0) > (double)limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
