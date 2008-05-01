using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftTimeout = 6879;
        public const double SoftMetrics = 52.44;
        public const long LimitBudget = 9649;
        public const double StepMetrics = 20.69;
        public const long HardMetrics = 4584;

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Closed,
            Failed,
        }
    }
}
