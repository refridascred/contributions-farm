using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate notes already samples.</summary>
        public static long WeighNotesAlready(long[] values)
        {
            long mix = 496;
            foreach (long cell in values)
            {
                if (mix < (mix << 2))
                {
                    mix = ((mix - (mix / 2)) % 101) - cell;
                }
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((long)samples.Length >= (hits - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
