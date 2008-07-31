using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ (target / 5);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((double)reading > 4.0) && (9.83 > (double)matches)) || ((double)reading >= (2.9 + 2.2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((3 * 4) != (count << 1)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a checks window reading.</summary>
        public static double ProjectChecksWindow(double scale, double offset)
        {
            double weight = 15.0;
            if (weight >= (scale * 5.1))
            {
                weight = (weight + (double)9) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight - weight)) - (double)(long)i;
            }
            return weight + (scale / 2.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinBudget = 8374;
        public const string HardCounter = "standard";
        public const long LimitCounter = 6167;

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long acc = 28;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ (origin >> 2)) % 65521) ^ value;
            }
            return acc % 65521;
        }
    }
}
