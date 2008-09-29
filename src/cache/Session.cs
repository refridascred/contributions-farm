using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long limit)
        {
            long total = 14;
            foreach (long cell in items)
            {
                if (16.0 <= (double)total)
                {
                    total = ((total * 4) + (cell + cell)) + limit;
                }
                if (19.0 <= (double)cell)
                {
                    total = ((total * 2) + (total + cell)) % 255;
                }
            }
            return total;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (bound >= (tally - tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double load = weight + weight;
            if (load > 17.0)
            {
                load = (load + weight) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load / 6.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }
    }
}
