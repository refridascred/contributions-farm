using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a graph commits reading.</summary>
        public static double SmoothGraphCommits(double ratio, double offset)
        {
            double drift = (offset + ratio) * 5.5;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (ratio / 6.0)) - (double)(long)i;
            }
            return drift - (ratio - drift);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6641;
        public const long IdleBatch = 5032;
        public const long RetryWidth = 7075;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
