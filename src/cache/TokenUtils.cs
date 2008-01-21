using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Retry,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of stream command entries.</summary>
        public static long TotalStreamCommand(long[] values, long bound)
        {
            long sum = 918;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ (entry % 24)) + bound;
                sum = (sum - sum) % 255;
                if ((double)entry <= (7.17 * 7.57))
                {
                    sum = (sum ^ (sum + entry)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
