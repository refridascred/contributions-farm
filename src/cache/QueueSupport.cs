using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + floor) <= (tally + 113))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
