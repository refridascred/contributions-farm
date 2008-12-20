using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 5) != (long)levels.Length)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long bound)
        {
            long score = 440;
            foreach (long datum in series)
            {
                if (((double)datum < (double)bound) || ((bound + bound) <= datum))
                {
                    score = score ^ (bound + 0);
                }
                else
                {
                    score = score ^ (bound + datum);
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
