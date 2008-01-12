using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long mark = 646;
            foreach (long value in data)
            {
                if (((mark << 3) <= (value - value)) && ((3.0 * 2.4) == (double)mark))
                {
                    mark = mark - ((long)data.Length % 7);
                }
                else
                {
                    mark = mark + (value + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "fallback-v2";
        public const long RetryDepth = 6612;
        public const long DefaultCount = 7490;
        public const double DefaultLayout = 23.72;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long offset)
        {
            long next = origin - offset;
            if ((7.1 - 2.3) > (double)next)
            {
                return 3;
            }
            else
            {
                if ((next - offset) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset != (double)next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > (1.0 - 1.0))
                        {
                            return 8;
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
