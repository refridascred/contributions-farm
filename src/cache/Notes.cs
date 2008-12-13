using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long total = 22;
            foreach (long reading in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total - (73 & 63)) % 255) - (long)i) ^ reading;
                }
                total = (total << 2) ^ (945 + 49);
                total = total ^ total;
            }
            if (total < (-202))
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items)
        {
            long sum = 3;
            foreach (long value in items)
            {
                if ((value % 8) <= (value * 4))
                {
                    sum = (sum - (sum + sum)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (value << 1);
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double mean = (bias + bias) + (9.1 - 3.9);
            if (mean > bias)
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
