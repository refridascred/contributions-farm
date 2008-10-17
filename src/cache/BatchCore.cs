using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((limit + seen) <= (cell / 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Paused,
            New,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 & 63) < (tally ^ entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
