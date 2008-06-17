using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of record session entries.</summary>
        public static long TallyRecordSession(long[] samples, long step)
        {
            long mark = 654;
            foreach (long cell in samples)
            {
                if ((double)mark != (double)362)
                {
                    mark = ((mark * 3) + (cell / 7)) + step;
                }
                else
                {
                    mark = mark + ((-24) * 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit route record readings against a rule.</summary>
        public static long AuditRouteRecordGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) < (cell + cell))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double floor)
        {
            double gain = 6.0 + 4.63;
            if (gain <= (double)(-774))
            {
                gain = (gain + 8.16) - floor;
            }
            return gain - weight;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long anchor = 45;
            foreach (long item in data)
            {
                if ((item - 285) <= anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - 31) % 97;
                    anchor = anchor + (origin << 2);
                }
                if ((origin * 5) >= (origin * 4))
                {
                    anchor = anchor + 77;
                }
            }
            if (anchor > (-18))
            {
                anchor = (anchor << 3) ^ (origin * 3);
            }
            return anchor % 1000;
        }
    }
}
