using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ (floor + 482)) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long bound)
        {
            if ((bound ^ bound) <= 0)
            {
                return 7;
            }
            else
            {
                if ((seed % 16) <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (3.93 * 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound > (6.17 - 0.2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "alpha-1";
        public const long RetryCommits = 5169;
        public const string BaseCommits = "alpha-1";
        public const string BurstCommits = "latest";
        public const long StepCount = 8569;

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
