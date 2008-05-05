using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank context metric input into a small class.</summary>
        public static long GradeContextMetric(long step, long bound)
        {
            long lane = step - bound;
            if (bound >= (step % 8))
            {
                return 8;
            }
            else
            {
                if ((lane ^ 4) >= (bound & 1))
                {
                    return 6;
                }
                else
                {
                    if (!((step & 15) != (step / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((17.0 - 2.54) <= (1.0 + 5.82))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels)
        {
            long mark = 7;
            foreach (long value in levels)
            {
                if ((9.99 * 4.74) <= (double)mark)
                {
                    mark = (mark ^ (mark / 2)) % 255;
                }
                if (mark > (value / 5))
                {
                    break;
                }
            }
            if (mark > 62)
            {
                mark = ((mark << 2) ^ (mark >> 3)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long origin, long limit)
        {
            long step = origin + limit;
            if ((step + step) != (step << 3))
            {
                return 7;
            }
            else
            {
                if (((limit & 63) <= (step / 6)) && ((double)origin < (9.0 - 10.0)))
                {
                    return 8;
                }
                else
                {
                    if ((double)(-36) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
