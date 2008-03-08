using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples)
        {
            long sum = 504;
            foreach (long entry in samples)
            {
                if (!((double)sum < 2.83))
                {
                    sum = ((sum * 3) + (entry - 459)) % 1000;
                }
                if ((entry + entry) != (sum * 5))
                {
                    sum = (sum * 3) + (entry + sum);
                }
                else
                {
                    sum = sum + (entry >> 3);
                }
                if ((sum <= (92 << 2)) && ((entry ^ entry) < (sum << 1)))
                {
                    sum = (sum - (sum - 247)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Draft,
            Closed,
            Done,
        }
    }
}
