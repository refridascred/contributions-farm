using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the batch report entries that pass the check.</summary>
        public static long AuditBatchReportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) != (tally & 31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Idle,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter session reading.</summary>
        public static double ProjectCounterSession(double weight, double offset)
        {
            double bias = weight / 5.0;
            if (bias < offset)
            {
                bias = bias - (double)906;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (weight / 3.0)) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Draft,
            New,
            Active,
        }
    }
}
