using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a farm order sample.</summary>
        public static long LookupFarmOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long acc = 93;
            foreach (long item in samples)
            {
                if (((double)acc >= (1.9 * 6.0)) || ((bound - 3) != (bound + bound)))
                {
                    acc = (acc << 3) ^ 83;
                }
                if ((item % 16) < (bound ^ bound))
                {
                    break;
                }
            }
            if (acc > (-3))
            {
                acc = ((acc * 4) + (acc ^ bound)) % 1000;
            }
            return acc;
        }
    }
}
