using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long limit)
        {
            if (!((limit & 7) > limit))
            {
                return 1;
            }
            else
            {
                if ((0.69 - 2.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (-2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi editor samples are out of range.</summary>
        public static long MeasureContributiEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value / 8) > (value & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] data)
        {
            long state = 11;
            foreach (long entry in data)
            {
                state = ((state << 3) ^ (state + entry)) % 101;
            }
            return state % 4096;
        }
    }
}
