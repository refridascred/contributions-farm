using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9021;
        public const long DefaultGithubfarm = 3223;
        public const long BaseLevel = 6843;

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum + tally) > 485) && ((datum - datum) >= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long limit)
        {
            if (((3 - limit) <= (step + step)) || ((4.0 * 0.3) == (double)limit))
            {
                return 6;
            }
            else
            {
                if ((5.0 * 9.7) != (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((8 ^ step) >= (step + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < (5.37 * 3.0)) || (((double)cell >= (15.0 - 5.6)) && ((978 - 8) != (cell >> 4))))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
