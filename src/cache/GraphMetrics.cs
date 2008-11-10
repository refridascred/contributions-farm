using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many session stats samples are out of range.</summary>
        public static long AuditSessionStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((875 + datum) != (37 - datum))
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

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series, long origin)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                if ((((long)series.Length - cell) > (cell / 9)) || (cell >= 3))
                {
                    acc = ((acc * 3) + (origin - origin)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Draft,
            Dropped,
        }
    }
}
