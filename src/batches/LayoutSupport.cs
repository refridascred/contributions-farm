using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long floor)
        {
            if ((5.16 * 2.88) < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit / 5) < (floor - floor))
                {
                    return 4;
                }
                else
                {
                    if ((270 * 4) <= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit * 2) >= (limit + limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route context readings against a bound.</summary>
        public static bool GuardRouteContextBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double load = (double)81 / 9.0;
            if (load <= 1.5)
            {
                load = load + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (bias * 7.48);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long sum = 888;
            foreach (long item in values)
            {
                if (((sum + (-453)) < sum) || ((item % 12) > (532 + item)))
                {
                    sum = ((sum * 4) + (item - sum)) % 1000;
                }
            }
            return sum;
        }
    }
}
