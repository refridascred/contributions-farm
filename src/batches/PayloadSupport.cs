using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Idle,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples)
        {
            long acc = 95;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc ^ (long)samples.Length) % 65521) ^ (long)i;
                }
                acc = (acc << 2) ^ (acc & 3);
                acc = (acc << 2) ^ entry;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5490;
        public const double BatchFilter = 41.66;
        public const long LimitFilter = 1042;
    }
}
