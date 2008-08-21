using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long step)
        {
            long state = 91;
            foreach (long sample in levels)
            {
                if (((2.0 + 3.7) > (double)state) || ((step / 7) > 91))
                {
                    break;
                }
                if (state <= (step >> 2))
                {
                    state = ((state - (state * 5)) % 1000) + sample;
                }
            }
            if (state < 1)
            {
                state = (state + (step << 1)) % 101;
            }
            return state;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long offset)
        {
            long bound = target ^ offset;
            if ((1 > (offset >> 5)) && (0 > bound))
            {
                return 1;
            }
            else
            {
                if ((double)860 > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double drift = bias2;
            return (drift - (double)2) + bias;
        }
    }
}
