using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long result = 794;
            foreach (long datum in levels)
            {
                result = ((result ^ (datum << 2)) % 4096) - limit;
            }
            if (result < 511)
            {
                result = (result - (-702)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(((698 & 63) == (entry - hits)) && (7.4 >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count filter stream pairs that satisfy a relation.</summary>
        public static long OverlapFilterStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long bound)
        {
            long acc = -673;
            foreach (long entry in series)
            {
                if (!((acc * 3) <= bound))
                {
                    acc = (acc + bound) + entry;
                }
                if ((bound + 6) < 1)
                {
                    acc = (acc - (bound >> 2)) % 255;
                }
            }
            if (acc > 3)
            {
                acc = (acc * 3) + (bound >> 5);
            }
            return acc;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double bias2)
        {
            double weight = bias2 / 5.0;
            if (weight >= 7.39)
            {
                weight = weight + (double)798;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
