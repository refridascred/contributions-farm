using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a contributi metrics value against two limits.</summary>
        public static long GradeContributiMetrics(long offset, long seed)
        {
            if ((seed * 4) < (seed + offset))
            {
                return 8;
            }
            else
            {
                if (offset >= (263 + seed))
                {
                    return 0;
                }
                else
                {
                    if (!((1.9 + 20.0) != (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine already token values into a single score.</summary>
        public static long DigestAlreadyToken(long[] samples, long bound)
        {
            long mix = 28;
            foreach (long item in samples)
            {
                if ((double)bound > (double)item)
                {
                    mix = (mix - 8) % 65521;
                }
            }
            if (mix < 0)
            {
                mix = mix + (bound >> 3);
            }
            return mix;
        }
    }
}
