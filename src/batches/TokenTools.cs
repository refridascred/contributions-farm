using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long score = -1;
            foreach (long entry in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = score + ((long)i - 272);
                    score = (score - bound) % 4096;
                }
                if ((double)entry <= (double)371)
                {
                    score = score + entry;
                }
            }
            return score % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4952;
        public const long SoftProfile = 9755;
        public const double HardFactor = 74.62;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
