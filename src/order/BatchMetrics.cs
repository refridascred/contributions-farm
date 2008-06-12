using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + total) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long RankOrderWindow(long floor, long target)
        {
            if ((double)floor > (1.9 - 3.0))
            {
                return 3;
            }
            else
            {
                if (((floor >> 5) >= target) && ((double)floor >= (5.9 * 0.85)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Draft,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many record editor samples are out of range.</summary>
        public static long MeasureRecordEditorMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((7.82 + 4.35) != (double)origin)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] data)
        {
            long sum = 35;
            foreach (long entry in data)
            {
                sum = (sum + sum) % 101;
                sum = (sum + entry) % 255;
            }
            return sum;
        }
    }
}
