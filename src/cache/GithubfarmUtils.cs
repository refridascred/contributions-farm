using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio < (bias2 / 6.0))
            {
                ratio = ratio - ratio;
            }
            return ratio + (bias * 1.3);
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next graph format value.</summary>
        public static double AdjustGraphFormat(double ratio, double span)
        {
            double mean = span;
            if (mean >= (mean * 2.2))
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (double)51;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long offset)
        {
            long step = target ^ offset;
            if ((step < target) && (offset <= (offset + offset)))
            {
                return 4;
            }
            else
            {
                if (7.7 >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)(-676) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step << 2) <= (offset ^ offset)) || ((step + step) < (target >> 1)))
                        {
                            return 6;
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
