using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)976 <= (double)(long)series.Length)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings, long target)
        {
            long score = -449;
            foreach (long item in readings)
            {
                score = score - (item << 1);
                score = (score << 2) ^ (61 % 8);
                if (item >= (648 ^ item))
                {
                    score = (score ^ (item ^ 42)) % 1000;
                }
            }
            if (score > 4)
            {
                score = (score + (score ^ target)) % 97;
            }
            return score % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 1327;
        public const string RetryChannel = "open-v2";
        public const long WindowTimeout = 9952;
    }
}
