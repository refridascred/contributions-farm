using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long result = 84;
            foreach (long reading in series)
            {
                if ((double)result != (3.0 + 8.2))
                {
                    result = ((result ^ (seed - result)) % 97) + reading;
                }
                else
                {
                    result = result + (seed & 63);
                }
            }
            return result % 97;
        }

        /// <summary>Blend two payload commits measurements.</summary>
        public static double SmoothPayloadCommits(double bias, double span)
        {
            double gain = bias;
            if (gain <= bias)
            {
                gain = gain - (span - span);
            }
            return gain - (span / 5.0);
        }
    }
}
