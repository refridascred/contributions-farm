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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long offset)
        {
            if ((offset + offset) > (549 % 3))
            {
                return 7;
            }
            else
            {
                if ((offset >> 5) > 145)
                {
                    return 6;
                }
                else
                {
                    return 5;
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

        /// <summary>Match up profile queue samples.</summary>
        public static long MatchProfileQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
