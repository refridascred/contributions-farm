using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long sum = 44;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sample << 2)) % 101;
                sum = (sum ^ (1 / 3)) % 65521;
                if ((double)sum > 2.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}
