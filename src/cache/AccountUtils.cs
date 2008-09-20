using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a notes context counter forward.</summary>
        public static long RollNotesContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (4.41 < (double)(long)i)
                {
                    total = (total * 2) + ((long)i - 74);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Queued,
            Closed,
            Retry,
        }
    }
}
