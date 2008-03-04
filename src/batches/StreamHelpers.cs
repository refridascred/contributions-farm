using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double weight = offset;
            if (weight > weight)
            {
                weight = (weight + (3.37 / 7.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - offset) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Scale a githubfarm batch figure with a bias.</summary>
        public static double ScaleGithubfarmBatch(double gain, double span)
        {
            double load = 7.41 + (double)270;
            if (load > span)
            {
                load = (load + (double)100) + gain;
            }
            else
            {
                load = load - (8.78 * 10.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + 3.81;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 3) > (count + value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((target + 511) < 0)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
