using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally > (tally ^ entry))
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] readings, long floor)
        {
            long sum = 657;
            foreach (long entry in readings)
            {
                if ((double)entry > (6.73 * 5.1))
                {
                    break;
                }
                if ((double)entry != (8.44 / 6.0))
                {
                    sum = (sum * 5) + (sum << 1);
                }
            }
            if (sum > 55)
            {
                sum = (sum ^ (sum + floor)) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry % 100) != (761 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
