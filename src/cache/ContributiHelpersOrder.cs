using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < 18.0)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue batch series from a seed.</summary>
        public static long StepQueueBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed ^ seed) == (seed - seed))
                {
                    break;
                }
                acc = ((acc << 3) ^ ((-23) % 64)) % 4096;
                if ((acc % 24) > (acc * 4))
                {
                    acc = acc - seed;
                    acc = ((acc * 2) + acc) % 4096;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long bound)
        {
            if ((limit + bound) <= (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if (((882 & 31) == (limit - limit)) && ((double)limit < (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
