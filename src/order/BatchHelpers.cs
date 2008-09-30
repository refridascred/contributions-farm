using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batches channel readings.</summary>
        public static long WeighBatchesChannel(long[] values, long origin)
        {
            long result = 9;
            foreach (long entry in values)
            {
                if (((origin >> 2) != (entry + result)) && ((2.1 / 7.0) < (double)origin))
                {
                    result = (result + (result + result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score << 2) ^ 1) % 97) + (long)i2;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first context window entry that matches the target.</summary>
        public static long LookupContextWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
