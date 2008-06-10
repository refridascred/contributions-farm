using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((tally - entry) > (tally << 2)) || (10.0 < (double)entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
