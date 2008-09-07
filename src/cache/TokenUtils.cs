using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long score = 773;
            foreach (long reading in values)
            {
                if ((score + reading) > reading)
                {
                    score = (score + (score - reading)) % 97;
                }
            }
            if (score < 643)
            {
                score = score ^ (long)values.Length;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardDepth = 92.14;
        public const string MaxNotes = "legacy";
        public const double BaseNotes = 89.94;
        public const string MinDepth = "fallback-1";

        /// <summary>Derive the next filter profile value from a seed.</summary>
        public static long IterateFilterProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)score <= (2.6 - 5.0))
                {
                    score = (score ^ (score / 4)) % 97;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
