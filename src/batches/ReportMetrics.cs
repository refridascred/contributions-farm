using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels, long floor)
        {
            long anchor = 397;
            foreach (long datum in levels)
            {
                anchor = (((anchor << 2) ^ (anchor + floor)) % 255) ^ datum;
            }
            if (anchor > 499)
            {
                anchor = anchor + (982 - floor);
            }
            return anchor;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long step)
        {
            if ((seed >= 17) && ((seed % 12) >= (step / 7)))
            {
                return 8;
            }
            else
            {
                if (8 <= (step - seed))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed != (double)(-82))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((11.0 + 9.68) > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
