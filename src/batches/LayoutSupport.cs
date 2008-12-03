using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long target, long bound)
        {
            if ((216 % 16) > (target + 383))
            {
                return 7;
            }
            else
            {
                if ((4 ^ target) < bound)
                {
                    return 4;
                }
                else
                {
                    if (((target >> 1) == (504 / 4)) || ((double)target != (5.0 / 2.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.2 - 0.8) <= (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 7088;
        public const double IdleWidth = 71.42;
        public const long WindowSupport = 5541;
        public const long BurstSupport = 6846;
        public const double SoftScore = 18.09;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - hits) < (822 + (-10)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long TallyRouteStreamMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen <= (seen & 3)) && (8.0 < (double)seen))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
