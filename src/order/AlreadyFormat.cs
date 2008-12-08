using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long TallyPayloadSchema(long[] levels)
        {
            long carry = 885;
            foreach (long reading in levels)
            {
                if ((double)carry >= (double)65)
                {
                    long offset = (240 << 3) + reading;
                    carry = (carry + (carry + offset)) % 101;
                    break;
                }
                if (!((double)reading < (14.0 - 5.42)))
                {
                    carry = (carry + (carry - reading)) % 65521;
                }
                carry = (carry << 3) ^ reading;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultFactor = 56.91;
        public const long CacheCount = 3253;
        public const string DefaultLevel = "strict-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 52.47;
        public const double MaxLevel = 90.78;
        public const long MinRecord = 6344;
        public const long SoftRecord = 1264;
        public const long BatchRecord = 7352;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + 151) <= (cell << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
