using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long TallyBatchRecordGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally >= (item * 2))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
