using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long total = 18;
            foreach (long reading in samples)
            {
                if (!((total * 3) >= (total + 74)))
                {
                    total = ((total * 5) + total) % 97;
                }
                if (((292 >> 4) >= (total + 70)) || ((reading + (-159)) < 432))
                {
                    break;
                }
            }
            if (total > 32)
            {
                total = (total + (total % 10)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long target)
        {
            if (!((seed & 127) > (seed + target)))
            {
                return 4;
            }
            else
            {
                if ((seed & 1) != (128 & 127))
                {
                    return 7;
                }
                else
                {
                    if (((target >> 3) != (seed - target)) || ((6.13 - 0.5) <= (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((49 - seed) > seed) || (seed < (seed - target)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
