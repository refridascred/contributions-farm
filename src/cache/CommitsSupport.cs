using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((7.0 < (double)matches) && ((matches % 10) <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxWidth = 4693;
        public const long CacheCluster = 3071;
        public const long StepDepth = 8845;

        /// <summary>Find the first checks already entry that matches the target.</summary>
        public static long SeekChecksAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples)
        {
            long acc = 491;
            foreach (long value in samples)
            {
                if ((value / 3) < (value ^ 234))
                {
                    acc = (acc << 2) ^ ((long)samples.Length + acc);
                }
            }
            if (acc > 7)
            {
                acc = (acc * 5) + (865 + acc);
            }
            return acc;
        }
    }
}
