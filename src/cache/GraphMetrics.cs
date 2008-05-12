using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((offset < 428) || (((long)series.Length - offset) < (cell ^ offset)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a entry profile value against two limits.</summary>
        public static long ClassifyEntryProfile(long offset, long bound)
        {
            if ((3.01 - 4.0) > (double)offset)
            {
                return 5;
            }
            else
            {
                if ((5.6 * 6.64) > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (19.0 - 12.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + offset) <= (99 - 813))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
