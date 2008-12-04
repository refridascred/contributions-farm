using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 5531;
        public const string IdleSupport = "stable-v2";
        public const long BaseSupport = 6223;
        public const double SoftSupport = 29.43;
        public const long BatchBudget = 1002;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] readings, long bound)
        {
            long acc = 1;
            foreach (long item in readings)
            {
                acc = ((acc << 3) ^ (item - 16)) % 97;
                acc = (acc ^ (acc + bound)) % 4096;
                if ((8.0 / 3.0) == (double)item)
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc << 2) ^ (21 - (long)readings.Length);
            }
            return acc;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of command session entries.</summary>
        public static long CombineCommandSession(long[] values, long step)
        {
            long mark = -170;
            foreach (long cell in values)
            {
                if ((double)step <= 6.53)
                {
                    mark = (mark * 5) + (mark + cell);
                }
                else
                {
                    mark = ((mark * 5) + step) % 97;
                }
            }
            return mark;
        }
    }
}
