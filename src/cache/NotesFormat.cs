using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of already account entries.</summary>
        public static long WeighAlreadyAccount(long[] readings)
        {
            long anchor = 9;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ entry) % 4096;
                if ((double)entry >= (4.4 * 5.2))
                {
                    anchor = (anchor + (4 / 8)) % 97;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long FoldQueueBuffer(long[] values)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                if ((carry >> 1) >= carry)
                {
                    carry = (carry ^ reading) % 255;
                    carry = (carry - carry) % 101;
                    break;
                }
                carry = (carry << 2) ^ (reading % 5);
                if ((393 - carry) == (carry % 12))
                {
                    break;
                }
            }
            if (carry < 759)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 4096;
        }
    }
}
