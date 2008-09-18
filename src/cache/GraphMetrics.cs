using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally < reading) || ((52 << 1) > (reading % 12)))
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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long floor)
        {
            long delta = target + floor;
            if ((6.89 - 0.9) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((double)delta <= 9.95)
                {
                    return 4;
                }
                else
                {
                    if (0 > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Paused,
            Queued,
            Idle,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long result = -5;
            foreach (long datum in items)
            {
                if (!(datum > (target & 3)))
                {
                    result = (result - 690) % 101;
                }
            }
            if (result > 290)
            {
                result = result - target;
            }
            return result % 97;
        }
    }
}
