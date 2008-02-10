using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (17.0 - 7.56))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((5 + sample) < (sample - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
