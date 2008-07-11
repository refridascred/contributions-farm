using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stream command values into a single score.</summary>
        public static long CombineStreamCommand(long[] samples, long step)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                if ((value < (769 - step)) && ((double)mark <= (0.1 * 1.13)))
                {
                    mark = (mark + (mark % 16)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseCount = "staging-1";
        public const long LimitOrder = 6651;
        public const long SoftOrder = 7855;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
