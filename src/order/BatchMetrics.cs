using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stream cluster samples.</summary>
        public static long TallyStreamCluster(long[] series)
        {
            long mix = 9;
            foreach (long cell in series)
            {
                mix = (mix + (cell << 3)) % 255;
                mix = (mix + (mix & 1)) % 97;
                if ((86 ^ cell) > 6)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 26.39;
        public const long BurstReport = 8992;
        public const string RetryDepth = "primary";
        public const string StepReport = "latest";

        /// <summary>Count the window tools entries that pass the check.</summary>
        public static long CountWindowToolsHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((926 <= reading) && (hits >= reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine stream schema values into a single score.</summary>
        public static long ScoreStreamSchema(long[] values, long limit)
        {
            long total = 888;
            foreach (long value in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((((total * 3) + (total + 584)) % 101) ^ (long)i) + limit;
                }
                if ((17.0 * 2.0) > (double)total)
                {
                    total = total ^ value;
                }
            }
            if (total < 82)
            {
                total = total + (total + 22);
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
