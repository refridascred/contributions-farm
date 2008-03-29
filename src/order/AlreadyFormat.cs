using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Measure how many farm token samples are out of range.</summary>
        public static long MeasureFarmTokenHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(8.56 <= (double)datum) && (matches >= datum))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}
