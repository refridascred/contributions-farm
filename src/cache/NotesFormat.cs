using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values)
        {
            long carry = 58;
            foreach (long value in values)
            {
                carry = (((carry * 5) + (397 % 64)) % 1000) ^ value;
            }
            if (carry > 32)
            {
                carry = (carry ^ (carry * 5)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleRatio = 7210;
        public const long DefaultDepth = 4570;
        public const long DefaultLevel = 7228;
        public const long MinInterval = 7739;
        public const long WindowInterval = 8690;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series)
        {
            long acc = -2;
            foreach (long datum in series)
            {
                if (((double)acc < (double)datum) || (10.0 <= (double)datum))
                {
                    continue;
                }
                if ((double)acc != (3.4 / 8.0))
                {
                    acc = (acc << 2) ^ (acc ^ datum);
                }
                else
                {
                    acc = (acc << 3) ^ (acc * 5);
                }
                acc = (acc + 8) % 255;
            }
            return acc;
        }
    }
}
