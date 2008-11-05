using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many cache batch samples are out of range.</summary>
        public static long CountCacheBatchOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((double)seed <= (3.93 - 5.13)) && (2.0 < (double)seed))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long anchor = -7;
            foreach (long cell in data)
            {
                anchor = (anchor + anchor) % 97;
                anchor = ((anchor * 2) + cell) % 1000;
                anchor = (anchor << 3) ^ (anchor >> 5);
                if ((anchor < (cell + cell)) && (cell < (anchor & 63)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double drift = offset;
            if (drift > (drift / 8.0))
            {
                drift = drift - (8.3 - weight);
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Failed,
            Draft,
            Paused,
            New,
        }
    }
}
