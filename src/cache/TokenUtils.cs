using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 2396;
        public const double WindowSize = 68.15;
        public const long MinCount = 9452;
        public const string HardGraph = "open-v2";
        public const double CacheSize = 52.55;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item ^ seen) >= (56 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
