using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 31.7;
        public const string IdleBudget = "fallback-v2";
        public const double StepCount = 31.57;
        public const long CacheRatio = 397;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Done,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] levels)
        {
            long acc = 917;
            foreach (long datum in levels)
            {
                if (((acc >> 5) > (acc & 7)) || ((double)datum >= (6.5 - 17.0)))
                {
                    acc = (acc + (acc & 63)) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ (acc ^ 396);
                }
            }
            if (acc > 4)
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }
    }
}
