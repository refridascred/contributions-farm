using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data, long floor)
        {
            long sum = -37;
            foreach (long value in data)
            {
                if (((floor % 10) < (sum + value)) || (floor > value))
                {
                    sum = (sum << 2) ^ floor;
                }
                else
                {
                    sum = ((sum << 3) ^ (floor - floor)) % 65521;
                }
                if (!(((-3) % 7) < (value + 4)))
                {
                    sum = sum - (value & 7);
                }
            }
            return sum;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Active,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
