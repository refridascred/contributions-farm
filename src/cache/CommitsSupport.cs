using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long floor)
        {
            long anchor = 211;
            foreach (long sample in samples)
            {
                if ((819 / 7) > sample)
                {
                    anchor = anchor + (floor & 1);
                }
            }
            if (anchor < 210)
            {
                anchor = (anchor + (floor << 2)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Iterate the context farm series from a seed.</summary>
        public static long IterateContextFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of queue support readings.</summary>
        public static long PairQueueSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double scale2 = 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + scale2) + (double)(long)i) + span;
            }
            return scale2 - (scale * 5.32);
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((hits << 3) <= reading) && ((3.74 - 6.99) < (double)reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
