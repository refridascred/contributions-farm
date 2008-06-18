using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (42 <= (offset * 2))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token command readings.</summary>
        public static long CombineTokenCommand(long[] levels, long limit)
        {
            long mix = 429;
            foreach (long item in levels)
            {
                if (((limit - mix) != (limit * 2)) && ((4 * 4) > (item - (-74))))
                {
                    mix = mix - (item + item);
                }
            }
            return mix;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double scale = gain / 4.0;
            return (scale - (3.0 + 6.9)) + span;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long total = 59;
            foreach (long datum in levels)
            {
                if (total < 91)
                {
                    total = (total - (161 << 1)) % 97;
                    total = total ^ (datum + 61);
                }
                else
                {
                    total = (total - (total & 63)) % 1000;
                }
                if ((3.9 / 8.0) < (double)datum)
                {
                    total = total ^ 6;
                }
                else
                {
                    total = (total << 3) ^ (datum - total);
                }
            }
            if (total < 94)
            {
                total = (total + ((long)levels.Length / 9)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((12.0 + 6.64) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit % 60) < (bound << 1))
                {
                    return 0;
                }
                else
                {
                    if (limit > (bound - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit < (bound % 97))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
