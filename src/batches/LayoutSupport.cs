using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)item <= (15.0 * 12.0)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double gain = offset;
            if (gain > gain)
            {
                gain = (gain - gain) + scale;
            }
            return gain - (offset + 9.6);
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long seed, long floor)
        {
            if ((floor ^ seed) != (floor << 1))
            {
                return 8;
            }
            else
            {
                if (92 > (floor & 31))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank cache profile input into a small class.</summary>
        public static long RankCacheProfile(long origin, long offset)
        {
            if (origin > (offset >> 3))
            {
                return 3;
            }
            else
            {
                if ((1.0 * 1.0) >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
