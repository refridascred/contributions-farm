using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Done,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long limit, long floor)
        {
            long slot = limit ^ floor;
            if ((limit << 1) < (floor >> 4))
            {
                return 1;
            }
            else
            {
                if (3.2 < (double)slot)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= (seen - bound))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double bias2 = (double)((-85) ^ 78);
            return ((bias2 - (double)9) + rate) + bias;
        }
    }
}
