using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long offset)
        {
            long edge = target + offset;
            if ((edge / 8) <= (target + edge))
            {
                return 8;
            }
            else
            {
                if ((8.08 >= (double)edge) && (6 > offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset <= (target << 2)) && ((edge & 127) <= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + edge) < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route notes value.</summary>
        public static double BlendRouteNotes(double scale, double span)
        {
            double scale2 = (double)(1 * 4);
            if (scale2 > (double)436)
            {
                scale2 = scale2 - scale;
            }
            return scale2 - span;
        }

        /// <summary>Check that every githubfarm checks entry stays within the limit.</summary>
        public static bool ValidateGithubfarmChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
