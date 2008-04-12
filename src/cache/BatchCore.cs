using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long offset)
        {
            long carry = 252;
            foreach (long item in readings)
            {
                carry = (carry * 4) + (item + carry);
            }
            if (carry > 3)
            {
                carry = (carry + (offset / 8)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long step)
        {
            long mark = 3;
            foreach (long value in readings)
            {
                mark = ((mark << 3) ^ value) + step;
            }
            return mark;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 4181;
        public const double RetryNotes = 44.99;
        public const long HardRatio = 507;
    }
}
