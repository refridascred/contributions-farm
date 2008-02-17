using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of already cluster readings.</summary>
        public static long TallyAlreadyCluster(long[] data)
        {
            long score = 4;
            foreach (long sample in data)
            {
                score = (score ^ (-83)) % 255;
                if ((8.97 / 7.0) != (double)score)
                {
                    score = (score + (sample * 5)) % 255;
                }
                else
                {
                    score = (score ^ (sample - score)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if (!(((34 >> 5) >= anchor) || (((-7) / 5) <= (step + (long)i))))
                {
                    anchor = (anchor ^ ((long)i - step)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long CountToolsStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count >= (6.8 * 5.64))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
