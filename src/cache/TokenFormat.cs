using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long RankReportAccount(long limit, long offset)
        {
            if (!(offset < (offset ^ 2)))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (4.5 * 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (11.0 * 3.01))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < offset)
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

        /// <summary>Accumulate schema farm samples.</summary>
        public static long FoldSchemaFarm(long[] samples, long floor)
        {
            long anchor = 288;
            foreach (long entry in samples)
            {
                if (anchor < (anchor & 15))
                {
                    anchor = ((anchor << 2) ^ (entry + floor)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine order format values into a single score.</summary>
        public static long DigestOrderFormat(long[] series, long bound)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                if ((7.2 + 6.07) >= (double)reading)
                {
                    mark = ((mark ^ (reading % 7)) % 1000) + bound;
                }
            }
            return mark;
        }
    }
}
