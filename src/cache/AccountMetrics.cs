using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long origin)
        {
            long slot = offset ^ origin;
            if (!((slot + offset) < (slot & 255)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) < 3)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (slot ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (slot - slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)6 == (double)(long)values.Length)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Active,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long origin)
        {
            long cur = target - origin;
            if (((origin & 63) >= (cur >> 5)) && ((double)target >= (0.5 / 2.0)))
            {
                return 1;
            }
            else
            {
                if (cur >= (origin + cur))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
        }
    }
}
