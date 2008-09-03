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

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples)
        {
            long acc = 505;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ acc) % 255;
                if ((entry + acc) >= (entry * 4))
                {
                    break;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels)
        {
            long carry = 90;
            foreach (long datum in levels)
            {
                carry = (carry + (carry + datum)) % 1000;
                if (datum >= carry)
                {
                    break;
                }
            }
            if (carry < (-503))
            {
                carry = ((carry << 3) ^ (carry << 2)) % 4096;
            }
            return carry;
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
