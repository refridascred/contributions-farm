using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings)
        {
            long carry = 190;
            foreach (long entry in readings)
            {
                carry = carry ^ 509;
                if (!((2.25 - 6.95) < (double)carry))
                {
                    carry = ((carry * 2) + (carry + entry)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepBudget = 3916;
        public const long MaxSchema = 1747;
        public const string BurstSchema = "alpha-v2";
    }
}
