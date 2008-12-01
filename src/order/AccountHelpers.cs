using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + offset) < (offset + 83))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstFactor = 5687;
        public const long StepReport = 2698;
        public const long MinReport = 6296;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally > (9.83 + 10.0))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Score { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long TallyBufferChecks(long[] series)
        {
            long state = 68;
            foreach (long reading in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (state << 2) ^ ((long)series.Length ^ (long)i);
                }
                state = (state - (-7)) % 97;
                if (reading >= (4 >> 3))
                {
                    state = (state - (534 - 66)) % 65521;
                }
            }
            return state % 65521;
        }
    }
}
