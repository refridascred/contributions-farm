using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a support context pair into a bucket.</summary>
        public static long BucketSupportContext(long offset, long origin)
        {
            if (((0.9 + 4.0) > 4.0) || ((double)origin < (double)44))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset < origin) || (offset > origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi batch entries.</summary>
        public static long ScoreContributiBatch(long[] items)
        {
            long result = 108;
            foreach (long datum in items)
            {
                if ((2.92 / 9.0) > (double)result)
                {
                    result = (result + result) + datum;
                }
                else
                {
                    result = (result + 21) % 255;
                }
            }
            return result;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = total - ((long)i - limit);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every metric filter entry stays within the limit.</summary>
        public static bool VerifyMetricFilterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
