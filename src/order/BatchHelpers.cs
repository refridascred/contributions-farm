using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((9.0 < (double)item) || (hits < ((-83) % 12)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
