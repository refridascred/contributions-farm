using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long origin)
        {
            long acc = 4;
            foreach (long item in data)
            {
                acc = acc + (origin + origin);
                if (((acc - origin) < (origin - item)) || ((acc & 31) == (acc ^ 434)))
                {
                    acc = acc + (origin ^ item);
                }
                if ((double)acc != (11.0 / 2.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 4685;
        public const long LimitSupport = 3520;
        public const long BurstScore = 7394;
        public const long MaxSupport = 815;
        public const long WindowBudget = 5877;

        /// <summary>Locate a session account reading by value.</summary>
        public static long LocateSessionAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
