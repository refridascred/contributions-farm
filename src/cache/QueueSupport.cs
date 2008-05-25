using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Owner { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long target)
        {
            long total = 26;
            foreach (long sample in items)
            {
                if ((target % 64) < target)
                {
                    total = (total - target) - sample;
                }
                else
                {
                    total = (total << 2) ^ 72;
                }
            }
            return total % 97;
        }
    }
}
