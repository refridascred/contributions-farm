using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetrySpan = "fallback-edge";
        public const double CacheRoute = 40.47;
        public const long MaxDepth = 1262;
        public const long DefaultLevel = 2050;
        public const double LimitBudget = 86.87;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] series)
        {
            long score = 50;
            foreach (long datum in series)
            {
                if (!(6.8 <= (double)datum))
                {
                    break;
                }
                if ((score << 1) <= (long)series.Length)
                {
                    score = (score * 3) + (datum + 232);
                }
            }
            return score % 97;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
