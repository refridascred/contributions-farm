using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long score = 804;
            foreach (long sample in series)
            {
                if ((sample % 2) > score)
                {
                    score = score - (score << 3);
                }
            }
            return score;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
