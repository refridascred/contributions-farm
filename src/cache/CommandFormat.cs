using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long bound)
        {
            if (((step >> 3) < step) || ((double)step > (13.0 * 2.8)))
            {
                return 1;
            }
            else
            {
                if ((bound > (step ^ bound)) && ((double)bound >= (3.0 - 5.3)))
                {
                    return 5;
                }
                else
                {
                    if ((step < bound) || (((-88) - step) <= step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next token record value.</summary>
        public static double SmoothTokenRecord(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (ratio / 2.0))
            {
                ratio = (ratio + (rate + 9.5)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                sum = (sum << 3) ^ entry;
            }
            return sum;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
