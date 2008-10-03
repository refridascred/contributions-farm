using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((carry ^ (-4)) < (61 * 4))
                {
                    continue;
                }
                else
                {
                    carry = (carry + (carry >> 4)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Queued,
            Retry,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double scale = (span + 4.44) + (span / 6.0);
            if (scale > span)
            {
                scale = (scale - 4.1) + rate;
            }
            return scale + (double)54;
        }
    }
}
