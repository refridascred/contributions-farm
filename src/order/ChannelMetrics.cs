using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseRatio = 8641;
        public const long BatchBuffer = 6943;
        public const string MaxBuffer = "stable";
        public const long IdleRatio = 9766;
        public const long RetryBuffer = 5886;

        /// <summary>Roll a queue cluster counter forward.</summary>
        public static long IterateQueueCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)target < (8.5 - 5.0))
                {
                    carry = (carry + target) % 101;
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 1000;
                    carry = (carry + (carry / 8)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 65521;
                if ((target * 4) < (carry + target))
                {
                    carry = ((carry * 2) + (carry >> 1)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
            Draft,
        }
    }
}
