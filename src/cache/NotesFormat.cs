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

        /// <summary>Validate contributi report readings against a bound.</summary>
        public static bool CheckContributiReportLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
