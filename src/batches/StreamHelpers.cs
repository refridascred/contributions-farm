using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long seed)
        {
            if ((89 ^ seed) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset >= 1.55)
                {
                    return 1;
                }
                else
                {
                    if (!(offset <= (817 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset > (7.0 - 10.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally >= (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches - matches) >= (offset ^ offset)) && ((entry + offset) != (matches << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(tally < 47))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream batches series from a seed.</summary>
        public static long DeriveStreamBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum ^ (long)i) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
