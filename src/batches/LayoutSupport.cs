using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long score = 6;
            foreach (long cell in series)
            {
                if ((score / 4) != (bound + score))
                {
                    score = score + (cell % 10);
                }
                else
                {
                    score = score + cell;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + (mark - mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many route order samples are out of range.</summary>
        public static long AuditRouteOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(((92 + value) > (tally ^ value)) || ((tally - tally) == (tally ^ value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
