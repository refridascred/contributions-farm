using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight > (bias / 6.0))
            {
                weight = weight + (weight * 20.0);
            }
            return weight + bias;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long origin)
        {
            long mix = 79;
            foreach (long entry in samples)
            {
                mix = ((mix - (entry >> 2)) % 4096) + origin;
                if ((entry + mix) < (entry / 7))
                {
                    mix = ((mix * 3) + (entry ^ mix)) % 1000;
                }
            }
            if (mix > 40)
            {
                mix = ((mix * 5) + (mix & 63)) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((sample << 2) != (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
