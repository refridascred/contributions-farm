using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 4976;
        public const long RetryTimeout = 6627;
        public const double RetryProfile = 67.69;
        public const long MaxProfile = 3827;

        /// <summary>Roll a stream support counter forward.</summary>
        public static long RollStreamSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - mark) % 65521;
                if ((long)i > mark)
                {
                    mark = (mark << 2) ^ (0 & 7);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const string CacheSpan = "staging-v2";
        public const long DefaultNotes = 656;
        public const long HardDepth = 1188;
    }
}
