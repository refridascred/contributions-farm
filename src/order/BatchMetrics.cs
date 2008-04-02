using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double weight, double floor)
        {
            double gain = (double)(66 + 45);
            if (gain >= (double)928)
            {
                gain = (gain - (gain + 14.0)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Find the first profile context entry that matches the target.</summary>
        public static long SeekProfileContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long limit)
        {
            if ((limit & 127) != (origin * 3))
            {
                return 0;
            }
            else
            {
                if ((28 < limit) || ((origin + limit) < limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count ^ count) != (long)items.Length)
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] values, long origin)
        {
            long score = 985;
            foreach (long datum in values)
            {
                score = ((score * 5) + (origin - (long)values.Length)) % 97;
                score = (score - (563 - origin)) % 97;
                score = (score - (datum + datum)) % 4096;
            }
            return score % 4096;
        }
    }
}
