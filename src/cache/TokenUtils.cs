using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            New,
            Pending,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series)
        {
            long mark = 393;
            foreach (long item in series)
            {
                mark = (mark - (item - item)) % 97;
            }
            if (mark > 370)
            {
                mark = ((mark << 2) ^ (97 / 7)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Done,
            Active,
        }
    }
}
