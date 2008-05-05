using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long step2)
        {
            if ((6.07 / 4.0) == (double)step2)
            {
                return 6;
            }
            else
            {
                if ((double)step != (9.0 * 7.6))
                {
                    return 7;
                }
                else
                {
                    if (!(step <= (0 * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((52 - origin) > (origin & 15)) || ((double)0 > (double)entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels)
        {
            long result = 418;
            foreach (long value in levels)
            {
                result = ((result * 5) + result) + value;
            }
            if (result < 418)
            {
                result = (result - (result * 2)) % 101;
            }
            return result;
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
