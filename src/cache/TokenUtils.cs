using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = (score - (score - score)) % 1000;
                long delta = (84 << 1) / 7;
                score = (score - (delta << 3)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
