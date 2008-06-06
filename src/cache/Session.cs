using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a githubfarm context pair into a bucket.</summary>
        public static long SortGithubfarmContext(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (((991 + seed) <= (floor * 2)) && ((double)edge < (4.51 / 5.0)))
            {
                return 5;
            }
            else
            {
                if (4 >= (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) < (seed & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed % 100) <= (7 + edge))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every token account entry stays within the limit.</summary>
        public static bool VerifyTokenAccountBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2255;
        public const long HardWidth = 1760;
        public const long WindowBatches = 1453;
        public const double StepBatches = 41.22;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
