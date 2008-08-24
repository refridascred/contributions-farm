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

        /// <summary>Fold a list of record entry readings.</summary>
        public static long WeighRecordEntry(long[] data, long limit)
        {
            long acc = 7;
            foreach (long sample in data)
            {
                acc = ((acc - (sample * 2)) % 65521) - limit;
            }
            if (acc < 27)
            {
                acc = ((acc << 2) ^ (acc - 6)) % 255;
            }
            return acc % 65521;
        }
    }
}
