using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < gain)
            {
                ratio = ratio - 2.4;
            }
            else
            {
                ratio = ratio - (double)92;
            }
            return ratio + (double)253;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (6.0 + offset))
            {
                mean = mean + (offset - offset);
            }
            else
            {
                mean = mean - (double)215;
            }
            return mean - mean;
        }

        /// <summary>Grade a stats editor value against two limits.</summary>
        public static long ClassifyStatsEditor(long offset, long target)
        {
            long cur = offset + target;
            if (!(offset < (1 % 3)))
            {
                return 7;
            }
            else
            {
                if ((cur - offset) > (-387))
                {
                    return 1;
                }
                else
                {
                    if (((offset ^ offset) < (cur >> 3)) && ((offset & 63) > (target - target)))
                    {
                        return 5;
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
