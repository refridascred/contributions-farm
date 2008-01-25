using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "alpha";
        public const long SoftLayout = 3036;
        public const long RetryFactor = 6032;
        public const string BurstSpan = "standard";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + entry) <= (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm graph pair into a bucket.</summary>
        public static long SortGithubfarmGraph(long target, long target2)
        {
            if ((target2 <= (target2 + target2)) || ((2.75 * 2.8) != (double)target))
            {
                return 1;
            }
            else
            {
                if (!(753 <= target))
                {
                    return 5;
                }
                else
                {
                    if (((target2 + target2) > 211) && ((8 ^ target2) <= (target2 - 971)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 7) < (target2 ^ target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
