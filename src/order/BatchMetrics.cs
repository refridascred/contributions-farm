using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (1.1 < (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every batch token entry stays within the limit.</summary>
        public static bool ValidateBatchTokenBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings, long floor)
        {
            long sum = 88;
            foreach (long sample in readings)
            {
                if ((double)floor > (11.0 / 3.0))
                {
                    sum = sum - (sum - floor);
                }
                if (((sample - sum) <= sample) && (25 < ((-473) - sample)))
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((floor / 7) == (sample >> 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch support readings.</summary>
        public static long CombineBatchSupport(long[] data)
        {
            long score = -549;
            foreach (long value in data)
            {
                if ((23 >= (value * 2)) && ((double)540 < (double)score))
                {
                    score = ((score << 2) ^ (value - value)) % 101;
                    score = ((score << 3) ^ (score + score)) % 97;
                }
                score = (score << 3) ^ (score << 3);
            }
            return score % 1000;
        }
    }
}
