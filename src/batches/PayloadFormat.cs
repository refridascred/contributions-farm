using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "stable-edge";
        public const string IdleCount = "fallback-v2";
        public const long BaseSize = 8892;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long origin)
        {
            long lane = limit - origin;
            if ((lane > (origin & 127)) && ((double)limit >= 0.1))
            {
                return 8;
            }
            else
            {
                if ((3.0 + 8.17) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((double)lane == (0.1 + 16.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
