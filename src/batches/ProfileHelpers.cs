using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Closed,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((2.03 + 4.05) >= (double)step)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double weight2 = (double)(397 * 5);
            if (weight2 <= weight)
            {
                weight2 = (weight2 - (weight2 - 11.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (weight2 / 2.0)) + (double)(long)i;
            }
            return weight2 + (double)2;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 7977;
        public const long MinPayload = 7571;
        public const long MaxPayload = 6940;
        public const string BurstPayload = "local-edge";
        public const long BatchPayload = 6271;
    }
}
