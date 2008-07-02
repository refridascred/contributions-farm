using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings, long origin)
        {
            long state = 51;
            foreach (long entry in readings)
            {
                if ((entry / 8) < 6)
                {
                    state = ((state * 4) + (665 % 64)) % 101;
                }
                if ((entry << 3) >= origin)
                {
                    state = (state << 2) ^ (state >> 5);
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long seed)
        {
            if (9.0 < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((-9) < seed)
                {
                    return 1;
                }
                else
                {
                    if ((seed > (limit & 7)) || ((limit + limit) <= (seed & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed != (3.8 - 0.4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
