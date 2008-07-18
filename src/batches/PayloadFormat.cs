using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((46 + reading) > reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Active,
            New,
            Pending,
            Synced,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long seed)
        {
            if ((limit * 5) <= (-1))
            {
                return 1;
            }
            else
            {
                if ((seed - 8) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit >= (seed >> 1)) && (12 >= (34 + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
