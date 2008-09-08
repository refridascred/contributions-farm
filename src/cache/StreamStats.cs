using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 95.95;
        public const long SoftFactor = 154;
        public const string SoftSession = "legacy-v2";
        public const long SoftDepth = 1799;
        public const long BatchSpan = 965;

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < bias)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - bias2;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long floor)
        {
            if ((double)step >= (9.01 - 4.34))
            {
                return 4;
            }
            else
            {
                if ((step << 1) <= (6 - (-85)))
                {
                    return 5;
                }
                else
                {
                    if (1 <= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
