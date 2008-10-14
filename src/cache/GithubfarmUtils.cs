using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((double)item > (8.0 - 15.0)) || ((0 << 3) != (tally + origin))) || ((tally - tally) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((9.31 + 19.0) > (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate graph tools readings against a bound.</summary>
        public static bool GuardGraphToolsRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
