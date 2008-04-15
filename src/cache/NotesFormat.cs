using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if (!(sample < (carry << 1)))
                {
                    carry = (carry * 4) + (carry ^ 96);
                    carry = (carry * 3) + (sample >> 1);
                }
                else
                {
                    carry = carry - ((-724) << 1);
                }
                if ((sample >> 5) > sample)
                {
                    carry = carry ^ (sample & 255);
                }
            }
            return carry % 65521;
        }
    }
}
