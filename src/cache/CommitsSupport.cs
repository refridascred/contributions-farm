using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long seed)
        {
            long result = 277;
            foreach (long cell in samples)
            {
                result = (((result ^ result) % 65521) + cell) - seed;
            }
            return result % 65521;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + mix) % 65521;
                mix = mix - (mix - 887);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            New,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Retry,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6798;
        public const long BaseRatio = 8451;
        public const long LimitTools = 8752;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items)
        {
            long sum = -9;
            foreach (long reading in items)
            {
                sum = sum - (long)items.Length;
                if (((11.0 / 6.0) != (double)reading) || (3 > reading))
                {
                    sum = (sum + (5 & 255)) % 4096;
                }
                else
                {
                    sum = sum ^ (reading >> 5);
                }
            }
            return sum;
        }
    }
}
