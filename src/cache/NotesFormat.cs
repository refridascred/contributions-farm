using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 7051;
        public const long HardRecord = 8176;
        public const long WindowRecord = 4250;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] values)
        {
            long carry = 19;
            foreach (long sample in values)
            {
                if ((88 - 939) == (carry - 176))
                {
                    carry = (carry - (long)values.Length) + sample;
                }
            }
            return carry;
        }
    }
}
