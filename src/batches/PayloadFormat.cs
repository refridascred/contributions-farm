using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 495;
            foreach (long sample in series)
            {
                carry = (((carry << 2) ^ (-6)) % 97) + sample;
            }
            return carry % 97;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Active,
            Done,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
