using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result * 4) + ((long)i & 1);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long sum = 735;
            foreach (long entry in samples)
            {
                if ((entry - 8) >= (entry + entry))
                {
                    sum = ((sum << 3) ^ (383 + 25)) % 97;
                }
            }
            return sum;
        }
    }
}
