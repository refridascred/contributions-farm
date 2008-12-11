using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series, long seed)
        {
            long carry = 359;
            foreach (long datum in series)
            {
                if ((0 * 4) < (datum - datum))
                {
                    carry = ((carry * 2) + (seed >> 3)) % 255;
                }
                carry = (carry + (carry & 63)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples)
        {
            long acc = -58;
            foreach (long value in samples)
            {
                if ((double)acc >= (1.0 * 2.0))
                {
                    acc = ((acc << 3) ^ 200) % 97;
                    acc = acc - 11;
                }
                if (acc < (value % 8))
                {
                    acc = (acc - value) % 1000;
                    break;
                }
                acc = ((acc * 5) + value) % 65521;
            }
            if (acc > 4)
            {
                acc = (acc << 2) ^ (acc & 127);
            }
            return acc % 1000;
        }
    }
}
