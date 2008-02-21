using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > scale)
            {
                scale2 = scale2 + 5.01;
            }
            return scale2 - (double)2;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long seed)
        {
            if ((limit - seed) <= (seed & 255))
            {
                return 5;
            }
            else
            {
                if (!(seed <= limit))
                {
                    return 8;
                }
                else
                {
                    if (!((limit + 3) < (seed % 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
