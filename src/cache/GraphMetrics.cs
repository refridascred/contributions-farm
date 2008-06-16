using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((377 ^ hits) == (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long step)
        {
            if ((step % 2) < offset)
            {
                return 3;
            }
            else
            {
                if (step > ((-4) + step))
                {
                    return 0;
                }
                else
                {
                    if (offset > (step ^ 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((12.0 / 7.0) <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item / 6) <= (matches + 9)))
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
