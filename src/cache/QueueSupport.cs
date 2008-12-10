using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a cluster queue pair into a bucket.</summary>
        public static long RankClusterQueue(long step, long seed)
        {
            long delta = step - seed;
            if ((delta * 2) != (step >> 3))
            {
                return 4;
            }
            else
            {
                if ((2.0 + 2.9) < (9.0 - 9.0))
                {
                    return 7;
                }
                else
                {
                    if (step < (step + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (5.95 < (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first farm format entry that matches the target.</summary>
        public static long LocateFarmFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long bound)
        {
            long score = 504;
            foreach (long item in samples)
            {
                score = (score ^ bound) % 4096;
                if (item >= (670 % 100))
                {
                    score = (score + bound) % 97;
                }
            }
            return score % 97;
        }
    }
}
