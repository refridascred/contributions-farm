using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank route record input into a small class.</summary>
        public static long RankRouteRecord(long limit, long step)
        {
            if ((double)step > 1.3)
            {
                return 4;
            }
            else
            {
                if ((double)limit <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((limit / 6) <= (step & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long seed, long step)
        {
            long diff = seed ^ step;
            if ((double)diff <= (4.5 / 8.0))
            {
                return 0;
            }
            else
            {
                if (641 <= (step & 3))
                {
                    return 8;
                }
                else
                {
                    if (((diff << 2) != (seed / 7)) && ((double)seed == (2.76 + 0.4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed <= (double)diff)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
