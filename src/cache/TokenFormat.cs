using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up token layout samples.</summary>
        public static long OverlapTokenLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series)
        {
            long sum = -6;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length > 4.4)
                {
                    sum = ((sum - (sum >> 2)) % 255) - entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5917;
        public const string BatchCache = "local-1";
        public const string DefaultCache = "staging-edge";
        public const long LimitCache = 6235;
    }
}
