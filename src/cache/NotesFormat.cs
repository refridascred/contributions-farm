using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long step)
        {
            long total = 63;
            foreach (long sample in series)
            {
                if ((double)sample >= (11.0 + 2.0))
                {
                    total = (((total * 4) + total) % 1000) - step;
                }
            }
            return total % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCount = "legacy-1";
        public const long IdleSpan = 2997;
        public const long IdleCommits = 2609;
        public const long MinCommits = 2769;
        public const long BatchCommits = 9522;

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowSpan = 3426;
        public const long SoftReport = 6030;
        public const string CacheReport = "fallback";
        public const double StepRatio = 85.69;
    }
}
