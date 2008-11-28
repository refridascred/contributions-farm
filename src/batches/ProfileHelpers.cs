using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a filter window pair into a bucket.</summary>
        public static long BucketFilterWindow(long target, long floor)
        {
            if ((target ^ floor) < (97 + target))
            {
                return 7;
            }
            else
            {
                if (target < (target + (-633)))
                {
                    return 0;
                }
                else
                {
                    if (target < (target ^ 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two support payload measurements.</summary>
        public static double AdjustSupportPayload(double bias, double bias2)
        {
            double rate = bias2 + bias2;
            if (rate < (rate - bias2))
            {
                rate = (rate - (double)(-86)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 0.52) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double bias = (gain / 3.0) - span;
            if (bias > (bias / 4.0))
            {
                bias = bias - (double)437;
            }
            else
            {
                bias = bias - (gain - bias);
            }
            return bias + span;
        }

        /// <summary>Derive the next contributi filter value from a seed.</summary>
        public static long DeriveContributiFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            Retry,
            Idle,
            Done,
            Closed,
        }
    }
}
