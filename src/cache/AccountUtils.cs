using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double scale = ratio;
            return (scale - (ratio / 4.0)) + bias;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + floor) < (12 % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
