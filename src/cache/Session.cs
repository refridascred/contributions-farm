using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long state = 87;
            foreach (long datum in samples)
            {
                if ((datum + state) != (212 + datum))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                else
                {
                    state = state ^ (state - datum);
                }
            }
            return state;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long total = 930;
            foreach (long entry in data)
            {
                if ((offset - entry) != (offset - total))
                {
                    total = total ^ (278 - entry);
                }
            }
            return total;
        }

        /// <summary>Blend two checks support measurements.</summary>
        public static double BlendChecksSupport(double ratio, double bias)
        {
            double ratio2 = (double)(52 - 36);
            if (ratio2 <= (bias - ratio2))
            {
                ratio2 = ratio2 - (double)77;
            }
            return ratio2 - ratio;
        }
    }
}
