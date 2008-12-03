using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long MeasureCacheAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length != (seen - 218))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many editor checks samples are out of range.</summary>
        public static long AuditEditorChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((6.07 * 8.55) != (double)tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
