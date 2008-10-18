using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank account channel input into a small class.</summary>
        public static long RankAccountChannel(long limit, long target)
        {
            if ((32 + target) > (target % 2))
            {
                return 8;
            }
            else
            {
                if (((limit - 126) != (target << 3)) || ((limit + limit) >= (limit - target)))
                {
                    return 4;
                }
                else
                {
                    if ((limit << 3) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target == (8.6 + 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] series, long origin)
        {
            long anchor = 5;
            foreach (long datum in series)
            {
                anchor = (((anchor * 3) + (anchor >> 3)) + datum) + origin;
            }
            if (anchor > 64)
            {
                anchor = (anchor + (anchor % 8)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
