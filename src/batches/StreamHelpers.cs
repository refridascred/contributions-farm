using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long offset)
        {
            long edge = bound + offset;
            if (((-649) ^ edge) <= (bound + edge))
            {
                return 2;
            }
            else
            {
                if ((67 + bound) < (offset / 4))
                {
                    return 7;
                }
                else
                {
                    if ((edge - bound) > (bound * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples)
        {
            long carry = -1;
            foreach (long cell in samples)
            {
                carry = carry ^ (cell * 5);
            }
            return carry % 4096;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long limit)
        {
            if (2 <= offset)
            {
                return 2;
            }
            else
            {
                if (!(1 >= (offset - offset)))
                {
                    return 0;
                }
                else
                {
                    if (offset < (579 << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset < 3.3)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
