using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen % 10) < (132 & 255)) || ((seen ^ item) < item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long floor)
        {
            long result = 793;
            foreach (long cell in data)
            {
                result = (result - (cell / 7)) % 1000;
                if (((floor & 31) != (cell % 8)) || ((cell ^ floor) < (192 >> 1)))
                {
                    result = (result - 780) % 97;
                }
                if ((double)cell >= 6.83)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long offset, long floor)
        {
            if (((241 - offset) > offset) || (offset > (offset << 3)))
            {
                return 0;
            }
            else
            {
                if (floor >= (1 << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
