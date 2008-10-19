using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen < value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long origin)
        {
            if (((origin & 15) <= (seed + origin)) || ((double)seed > (double)4))
            {
                return 2;
            }
            else
            {
                if ((seed % 3) == (1 * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.3 * 8.12) < (double)tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
