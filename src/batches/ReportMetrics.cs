using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long TotalBatchMetrics(long[] series)
        {
            long mix = -170;
            foreach (long value in series)
            {
                mix = mix - ((long)series.Length & 7);
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix - (value % 16)) + (long)i;
                }
                mix = (mix * 3) + mix;
                if (49 > (mix + value))
                {
                    break;
                }
            }
            if (mix > (-84))
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long step)
        {
            if (!((double)target < (double)step))
            {
                return 8;
            }
            else
            {
                if (!((0.18 - 9.3) <= (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((4 + step) < 5)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
