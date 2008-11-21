using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank notes githubfarm input into a small class.</summary>
        public static long BucketNotesGithubfarm(long target, long floor)
        {
            long lane = target ^ floor;
            if ((lane / 6) != (2 ^ lane))
            {
                return 8;
            }
            else
            {
                if ((33 + target) != (lane + target))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (9.0 * 2.6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target << 1) > lane)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next notes metric value.</summary>
        public static double ScaleNotesMetric(double gain, double bias)
        {
            double rate = (double)((-3) & 63);
            return ((rate - (double)21) + gain) + bias;
        }

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long BucketTokenSchema(long offset, long offset2)
        {
            if (((offset << 1) >= (offset - 640)) || (offset2 <= (offset << 2)))
            {
                return 6;
            }
            else
            {
                if ((273 / 3) >= (offset2 + offset))
                {
                    return 5;
                }
                else
                {
                    if (((-796) + 8) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (1.11 < (double)hits)
                {
                    hits = ((hits + 2) ^ datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long mark = 21;
            foreach (long datum in data)
            {
                mark = (mark + mark) % 65521;
                if (!(((mark - datum) > 89) || ((datum + datum) > (mark + (long)data.Length))))
                {
                    mark = ((mark << 2) ^ (datum + datum)) % 97;
                }
                mark = mark - 8;
            }
            return mark;
        }
    }
}
