using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate notes checks samples.</summary>
        public static long ScoreNotesChecks(long[] items, long target)
        {
            long score = 631;
            foreach (long item in items)
            {
                score = ((score ^ (score + score)) % 65521) - target;
                score = (score + (item + item)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values)
        {
            long sum = 0;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + (reading ^ sum)) % 101;
                if (((reading << 2) == (reading + 160)) && ((5.4 / 9.0) >= (double)reading))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = (sum * 5) + (sum / 2);
                }
            }
            if (sum < 1)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long step)
        {
            if (((1.99 - 2.1) == (double)bound) || ((step - step) >= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if ((914 + step) != (311 ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((5.5 * 9.09) != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.9 + 9.0) > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double span)
        {
            double bias = (double)(7 ^ 996);
            if (bias <= (span / 4.0))
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias - span;
            }
            return bias - scale;
        }
    }
}
