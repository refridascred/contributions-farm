using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                total = ((total * 5) + (total + sample)) % 97;
            }
            return total;
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
