using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples)
        {
            long score = -1;
            foreach (long cell in samples)
            {
                if (score <= (cell & 63))
                {
                    score = ((score * 4) + (cell << 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] items, long seed)
        {
            long acc = 70;
            foreach (long sample in items)
            {
                if ((46 + 4) <= (acc << 2))
                {
                    acc = ((acc << 3) ^ (acc ^ 78)) ^ sample;
                }
                else
                {
                    acc = (acc * 5) + (seed ^ seed);
                }
            }
            if (acc > 3)
            {
                acc = (acc - (acc ^ 0)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Scale a counter editor figure with a bias.</summary>
        public static double SmoothCounterEditor(double ratio, double offset)
        {
            double weight = ratio - offset;
            if (weight < weight)
            {
                weight = weight + (weight * 9.84);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight * 5.95)) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many filter batch samples are out of range.</summary>
        public static long TallyFilterBatchHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) > (floor >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
