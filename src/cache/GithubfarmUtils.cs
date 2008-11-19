using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a batch batches figure with a bias.</summary>
        public static double BlendBatchBatches(double bias, double offset)
        {
            double gain = (offset - offset) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - offset) - (double)(long)i) - bias;
            }
            return gain - offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8283;
        public const long HardRatio = 6622;
        public const string RetryGithubfarm = "local-1";
        public const long BurstSize = 9422;
        public const long IdleRatio = 8758;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((long)samples.Length >= (hits & 3)) && (limit <= (7 + limit))) && ((value << 2) > hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
