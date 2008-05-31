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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
