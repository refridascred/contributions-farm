using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Iterate the checks report series from a seed.</summary>
        public static long StepChecksReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i > (origin & 7))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many filter order samples are out of range.</summary>
        public static long TallyFilterOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally % 64) >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
