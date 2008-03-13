using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next format notes value from a seed.</summary>
        public static long DeriveFormatNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 1635;
        public const long LimitBuffer = 1654;
        public const long BurstBudget = 6950;
        public const double IdleLevel = 76.6;
        public const double RetryTimeout = 69.48;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Pending,
            Done,
        }
    }
}
