using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double scale = (double)(26 * 3);
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - (double)186) + (double)(long)i) - bias) - floor;
            }
            return scale - (double)8;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long acc = 81;
            foreach (long entry in levels)
            {
                if (((acc & 31) != (acc - acc)) || (30 > acc))
                {
                    acc = (acc * 2) + acc;
                }
                else
                {
                    acc = ((acc << 2) ^ (1 % 10)) % 1000;
                    acc = ((acc << 2) ^ acc) % 101;
                }
                acc = acc + (47 + acc);
                if (((double)entry < (double)acc) && ((double)entry == (17.0 + 9.9)))
                {
                    acc = (acc * 3) + (entry * 4);
                }
                else
                {
                    acc = ((acc << 2) ^ (6 ^ 93)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Iterate the report window series from a seed.</summary>
        public static long RollReportWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (989 <= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
