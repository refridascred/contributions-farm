using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value & 3) <= (value % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] data, long bound)
        {
            long mix = 25;
            foreach (long sample in data)
            {
                mix = ((mix + (mix % 12)) ^ sample) - bound;
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }
    }
}
