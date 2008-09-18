using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long target)
        {
            long gap = offset + target;
            if (!((target + gap) >= (offset ^ offset)))
            {
                return 2;
            }
            else
            {
                if (!(5.96 <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset < (offset ^ gap)) && ((offset & 7) < target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
