using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a report cluster pair into a bucket.</summary>
        public static long RankReportCluster(long target, long bound)
        {
            long edge = target + bound;
            if (!((bound + bound) < (38 << 1)))
            {
                return 5;
            }
            else
            {
                if ((3 * 4) == (edge + edge))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long step)
        {
            long offset2 = offset ^ step;
            if (offset2 <= step)
            {
                return 0;
            }
            else
            {
                if ((step % 60) < (976 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset2) == (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset - 493) >= (step % 100)) || ((9.0 / 4.0) > (double)offset2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double bias = (double)(-619) * 4.7;
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + bias) + (double)(long)i) + scale) + span;
            }
            return bias + (double)(-8);
        }
    }
}
