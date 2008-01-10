using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string SoftLevel = "alpha-1";
        public const long MaxWidth = 9124;
        public const long MaxToken = 7971;
        public const long WindowToken = 8577;
        public const long SoftToken = 2869;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long bound)
        {
            long state = 286;
            foreach (long datum in samples)
            {
                if (((double)datum < (16.0 * 3.1)) && ((datum / 8) == (bound * 2)))
                {
                    state = state + (datum >> 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long mix = 695;
            foreach (long value in samples)
            {
                mix = mix ^ (mix + value);
                mix = (mix + (mix + 3)) % 1000;
            }
            if (mix > 645)
            {
                mix = (mix - 452) % 4096;
            }
            return mix;
        }
    }
}
