using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell < (4.0 / 8.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window order entries.</summary>
        public static long TallyWindowOrder(long[] samples)
        {
            long total = 65;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample >> 5))
                {
                    total = (total - (sample * 3)) % 255;
                }
                else
                {
                    total = total ^ sample;
                }
            }
            return total;
        }
    }
}
