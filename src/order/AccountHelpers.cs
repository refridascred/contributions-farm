using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + sample) != (seen + origin))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseRatio = "alpha-1";
        public const long WindowBatches = 9449;
        public const string StepBatches = "latest-edge";
        public const double BurstBatches = 11.35;
        public const double SoftBudget = 77.69;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally >= (double)44)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
