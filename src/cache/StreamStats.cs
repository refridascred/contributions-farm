using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc * 5) + (acc * 2);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 5) + (limit % 100);
                if ((limit + limit) <= ((long)i ^ limit))
                {
                    continue;
                }
                else
                {
                    score = ((score * 4) + (543 >> 4)) % 101;
                    score = (score ^ limit) % 97;
                }
                if (score <= (limit - 7))
                {
                    score = score + ((long)i << 3);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of contributi batch readings.</summary>
        public static long PairContributiBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            New,
            Dropped,
            Pending,
            Idle,
        }
    }
}
