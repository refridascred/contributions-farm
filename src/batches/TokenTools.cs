using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5645;
        public const double BaseCluster = 6.26;
        public const double RetryCluster = 22.89;
        public const long StepCluster = 4824;
        public const string BatchCluster = "latest-v2";

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

        /// <summary>Grade a schema profile value against two limits.</summary>
        public static long RankSchemaProfile(long floor, long offset)
        {
            long delta = floor - offset;
            if (((double)floor < (7.9 - 9.0)) && ((floor - delta) <= (45 * 3)))
            {
                return 4;
            }
            else
            {
                if ((double)floor == (11.0 * 4.91))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
