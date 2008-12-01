using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 9744;
        public const long StepAlready = 6059;
        public const double CacheAlready = 95.81;

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long TotalEditorStream(long[] samples, long origin)
        {
            long acc = 702;
            foreach (long cell in samples)
            {
                if (((14.0 / 7.0) == (double)cell) && (origin >= (cell >> 2)))
                {
                    break;
                }
                if ((cell << 2) >= (acc - cell))
                {
                    acc = ((acc * 3) + (acc + origin)) % 97;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            if (acc > (-6))
            {
                acc = (acc << 3) ^ (58 ^ origin);
            }
            return acc;
        }

        /// <summary>Fold a list of already payload readings.</summary>
        public static long FoldAlreadyPayload(long[] values)
        {
            long carry = 48;
            foreach (long reading in values)
            {
                if (!((reading + 74) < 1))
                {
                    carry = carry ^ (reading + carry);
                }
                if (((97 - reading) != (reading & 7)) && ((-11) >= carry))
                {
                    carry = (carry + reading) % 101;
                }
                if (!(0.8 >= (double)carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
