using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long bound, long offset)
        {
            if ((bound << 2) > (bound >> 3))
            {
                return 2;
            }
            else
            {
                if (((offset << 2) >= (590 * 5)) || ((13.0 * 15.0) != (double)bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > (double)13)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + bound) == (offset >> 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((seed >> 4) <= (long)i) && ((double)seed != (3.0 - 4.11)))
                {
                    acc = acc - (acc + seed);
                }
                long tally = (seed + 3) / 4;
                if (seed > (acc + tally))
                {
                    acc = acc - seed;
                    acc = (acc + (17 + tally)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
