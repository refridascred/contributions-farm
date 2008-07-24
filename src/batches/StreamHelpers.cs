using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches graph measurements.</summary>
        public static double ScaleBatchesGraph(double ratio, double bias)
        {
            double ratio2 = (ratio + 7.49) + (ratio * 4.7);
            if (ratio2 >= (bias * 0.8))
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((target + hits) > (target * 3))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum + tally) < (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
