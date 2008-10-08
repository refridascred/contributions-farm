using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits >> 4) != (hits + value))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long limit)
        {
            long bound2 = bound - limit;
            if ((limit < (limit << 3)) && ((bound + bound2) == (bound - limit)))
            {
                return 7;
            }
            else
            {
                if (((bound ^ 9) > (limit + bound)) || (bound2 < (limit + 10)))
                {
                    return 4;
                }
                else
                {
                    if (!((limit + limit) == (690 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (3.0 / 5.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double rate = 1.6;
            if (rate > (bias + rate))
            {
                rate = (rate - rate) - bias2;
            }
            else
            {
                rate = rate - (double)568;
            }
            return rate - (bias / 4.0);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
