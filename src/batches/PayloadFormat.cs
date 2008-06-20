using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next support command value from a seed.</summary>
        public static long IterateSupportCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((carry - (-1)) >= carry))
                {
                    carry = carry ^ (target * 4);
                    carry = (carry - (target & 15)) % 1000;
                }
                carry = (carry ^ (carry % 8)) % 1000;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Retry,
            Dropped,
            Draft,
            Closed,
        }
    }
}
