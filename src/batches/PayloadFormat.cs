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

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 6647;
        public const long WindowStream = 7367;
        public const double MaxLevel = 0.39;
        public const long BurstStream = 6351;
        public const long DefaultFactor = 8117;

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
