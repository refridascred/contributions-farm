using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((15 ^ item) < (hits % 10))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long bound)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if ((mix & 255) >= (900 - (long)values.Length))
                {
                    mix = ((mix << 3) ^ (bound % 7)) ^ datum;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix > 95)
            {
                mix = (mix ^ ((-894) ^ bound)) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long origin)
        {
            long score = 975;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (origin + score)) - item;
                score = (score ^ score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Check that every session queue entry stays within the limit.</summary>
        public static bool CheckSessionQueueLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
