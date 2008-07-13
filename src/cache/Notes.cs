using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) != (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long offset)
        {
            long next = target - offset;
            if (!((offset << 2) <= (target ^ target)))
            {
                return 8;
            }
            else
            {
                if ((target & 7) != (274 + next))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double weight = scale;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (offset - 8.36)) + (double)(long)i;
            }
            return weight + 5.11;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Stale,
            Closed,
            Done,
            Failed,
        }
    }
}
