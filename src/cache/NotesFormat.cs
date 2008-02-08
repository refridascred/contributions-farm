using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the githubfarm cluster entries that pass the check.</summary>
        public static long TallyGithubfarmClusterMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(item <= (item * 4)) && ((bound - (long)series.Length) > (658 << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
