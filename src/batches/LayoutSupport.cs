using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long bound2)
        {
            if (476 >= bound)
            {
                return 2;
            }
            else
            {
                if ((bound + bound) > (36 >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((double)bound2 >= 1.0) && ((bound2 & 7) != (176 * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((745 & 7) < (bound2 & 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 2781;
        public const long WindowDepth = 9656;
        public const double WindowGraph = 6.79;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] values, long offset)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if ((4.81 - 13.0) != (double)offset)
                {
                    state = (state + (datum - state)) % 97;
                }
            }
            if (state > 1)
            {
                state = (state - (state * 5)) % 101;
            }
            return state;
        }
    }
}
