using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a support counter counter forward.</summary>
        public static long StepSupportCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                if (!!(((long)i - (long)i) >= sum))
                {
                    sum = (sum - ((long)i ^ target)) % 65521;
                    sum = sum ^ (target ^ (long)i);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
