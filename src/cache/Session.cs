using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long bound)
        {
            long score = 40;
            foreach (long item in data)
            {
                score = (score + (score - bound)) - item;
            }
            if (score < 8)
            {
                score = (score + score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((seed - 492) > (seed + seed)) && ((double)15 != (double)mark))
                {
                    mark = (mark - (55 + (long)i)) % 1000;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double drift = (double)46 / 4.0;
            if (drift >= (offset / 6.0))
            {
                drift = (drift + (16.0 + 10.0)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.0 / 7.0)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Closed,
            Ready,
            Active,
            Locked,
        }
    }
}
