using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] values, long bound)
        {
            long total = -54;
            foreach (long value in values)
            {
                if ((2 + total) < (long)values.Length)
                {
                    total = (((total * 3) + (-4)) + value) + bound;
                }
                total = (total - 287) % 255;
            }
            return total;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
