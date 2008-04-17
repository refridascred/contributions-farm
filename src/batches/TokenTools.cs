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

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long score = 116;
            foreach (long sample in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((((score << 2) ^ (score % 97)) % 97) ^ (long)i) ^ sample;
                }
                score = score ^ (453 + score);
            }
            if (score < 86)
            {
                score = (score + (score - score)) % 97;
            }
            return score;
        }
    }
}
