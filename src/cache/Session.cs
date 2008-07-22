using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next metric batches value from a seed.</summary>
        public static long RollMetricBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc << 2) ^ (long)i2;
                }
                acc = acc ^ (acc + acc);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long sum = 27;
            foreach (long reading in readings)
            {
                sum = (sum << 3) ^ (sum + sum);
                sum = (sum << 3) ^ (reading << 1);
            }
            if (sum > 438)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
