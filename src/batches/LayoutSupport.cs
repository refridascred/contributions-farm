using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] series, long step)
        {
            long score = 0;
            foreach (long entry in series)
            {
                if ((entry * 4) <= entry)
                {
                    score = (score * 5) + 9;
                }
                if (((entry - step) <= (68 * 4)) && ((94 % 60) >= score))
                {
                    score = (score + ((long)series.Length + score)) % 101;
                }
                else
                {
                    score = ((score * 5) + (entry & 3)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long offset)
        {
            long delta = origin + offset;
            if (((-9) & 31) != (delta % 2))
            {
                return 6;
            }
            else
            {
                if (((offset & 255) >= (offset * 4)) || ((offset + delta) <= (origin + origin)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many cache account samples are out of range.</summary>
        public static long AuditCacheAccountOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)seen >= 13.0))
                {
                    seen = ((seen + 1) + entry) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double span)
        {
            double load = gain;
            return load - (span + load);
        }
    }
}
