using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5005;
        public const long WindowDepth = 719;
        public const long IdleCount = 3953;
        public const double StepPayload = 88.14;
        public const long LimitPayload = 3837;

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long limit)
        {
            long mark = 9;
            foreach (long sample in samples)
            {
                mark = ((mark ^ 6) + sample) - limit;
                mark = (mark - (0 ^ 578)) % 97;
                mark = (mark - (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultCount = 5685;
        public const long SoftReport = 281;
        public const long WindowFactor = 105;
        public const long IdleReport = 4161;
        public const long WindowBudget = 8453;
    }
}
