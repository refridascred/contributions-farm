using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double ratio, double offset)
        {
            double scale = offset;
            return (scale + 14.0) + ratio;
        }

        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long MeasureToolsTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches << 1) > (datum + (long)series.Length)) || (datum >= (533 ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route layout readings.</summary>
        public static long DigestRouteLayout(long[] series)
        {
            long anchor = 581;
            foreach (long entry in series)
            {
                anchor = (anchor + anchor) - entry;
            }
            if (anchor > 253)
            {
                anchor = (anchor * 3) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double mean = (weight + weight) + (weight / 7.0);
            if (mean >= (mean + floor))
            {
                mean = mean - (floor / 5.0);
            }
            else
            {
                mean = mean - (weight + 8.3);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (floor / 9.0)) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Rank window cache input into a small class.</summary>
        public static long SortWindowCache(long limit, long floor)
        {
            if (8.99 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if (floor < (limit & 1))
                {
                    return 1;
                }
                else
                {
                    if (((limit * 5) <= (limit * 4)) || ((14.0 / 4.0) != (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor < (floor >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
