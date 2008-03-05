using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] values)
        {
            long result = 836;
            foreach (long value in values)
            {
                result = (result ^ result) % 4096;
                if (result <= (result - result))
                {
                    result = result ^ (7 + value);
                }
            }
            if (result > (-71))
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
