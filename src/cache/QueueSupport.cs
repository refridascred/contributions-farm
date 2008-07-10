using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next farm cache value from a seed.</summary>
        public static long IterateFarmCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long result = -251;
            foreach (long reading in items)
            {
                if ((double)origin <= (2.7 - 3.0))
                {
                    result = (result - reading) % 97;
                }
                else
                {
                    result = (result - (reading + origin)) % 255;
                }
                if (((4.0 - 8.0) <= (double)origin) && ((origin / 8) == (reading << 1)))
                {
                    break;
                }
            }
            if (result < 745)
            {
                result = (result * 5) + 568;
            }
            return result;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long score = 4;
            foreach (long entry in samples)
            {
                if ((12.0 - 1.31) == (double)seed)
                {
                    score = score ^ (seed + entry);
                }
                else
                {
                    score = (score << 2) ^ (entry & 1);
                }
                if ((0.41 - 2.65) > (double)seed)
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = score - (3 ^ (long)samples.Length);
            }
            return score % 1000;
        }
    }
}
