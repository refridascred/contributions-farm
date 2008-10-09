using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit farm route readings against a rule.</summary>
        public static long TallyFarmRouteMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)seed >= 12.0)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 1589;
        public const long SoftEntry = 6411;
        public const long LimitEntry = 2818;

        /// <summary>Count order command pairs that satisfy a relation.</summary>
        public static long PairOrderCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
