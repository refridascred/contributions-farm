using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long CountSupportClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >> 3) >= (645 - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long origin)
        {
            if (941 <= (step * 5))
            {
                return 0;
            }
            else
            {
                if ((step & 1) < step)
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ 1) >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
