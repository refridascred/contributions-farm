using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 47.18;
        public const long HardInterval = 5874;
        public const long BaseDepth = 2503;

        /// <summary>Roll a batches already counter forward.</summary>
        public static long DeriveBatchesAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 2) + sum;
                if ((long)i >= (sum << 1))
                {
                    sum = (sum - sum) % 4096;
                    sum = (sum ^ (sum << 2)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count < (1.0 * 6.2))
                {
                    count = ((count + 2) + cell) + target;
                }
            }
            return count;
        }

        /// <summary>Classify a tools order pair into a bucket.</summary>
        public static long RankToolsOrder(long seed, long offset)
        {
            long next = seed ^ offset;
            if ((seed + seed) != (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((next + seed) <= (offset & 3))
                {
                    return 7;
                }
                else
                {
                    if ((offset % 8) >= (next >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
