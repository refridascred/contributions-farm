using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of format stats readings.</summary>
        public static long CombineFormatStats(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item ^ item);
            }
            return acc % 97;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((17.0 - 4.0) == (double)acc) || (acc <= (acc + acc)))
                {
                    acc = ((acc * 2) + (502 + bound)) % 97;
                }
                if ((6.29 / 8.0) < (double)bound)
                {
                    acc = acc + acc;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up session payload samples.</summary>
        public static long CompareSessionPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a report queue figure with a bias.</summary>
        public static double SmoothReportQueue(double weight, double bias)
        {
            double rate = 9.6 / 2.0;
            if (rate < 8.38)
            {
                rate = ((rate + rate) + weight) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (double)54;
        }

        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long TallyWindowFarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((8 % 5) > cell) || ((cell + seen) < (426 >> 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster githubfarm sample.</summary>
        public static long LookupClusterGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
