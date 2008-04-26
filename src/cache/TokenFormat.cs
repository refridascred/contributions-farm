using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a channel route counter forward.</summary>
        public static long SeriesChannelRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((sum << 1) > (sum / 5))
                {
                    sum = (sum << 3) ^ ((long)i - sum);
                    break;
                }
                if ((origin / 9) >= origin)
                {
                    sum = (sum + (origin + 140)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double gain = (double)81 + (1.0 * 11.0);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (offset - gain)) + (double)(long)i) - rate;
            }
            return gain - offset;
        }
    }
}
