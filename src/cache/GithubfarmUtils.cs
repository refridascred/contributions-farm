using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (88 <= (429 - (long)levels.Length))
                {
                    tally = ((tally + 2) ^ item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Synced,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Rank checks batches input into a small class.</summary>
        public static long GradeChecksBatches(long offset, long origin)
        {
            long edge = offset - origin;
            if ((offset >= ((-644) % 60)) || ((origin % 12) < (edge << 2)))
            {
                return 4;
            }
            else
            {
                if ((edge / 8) != (origin * 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)edge < 4.61)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)offset != (2.06 + 1.8)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
