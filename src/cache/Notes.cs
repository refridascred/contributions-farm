using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long TallySupportWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + value) >= 1)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Synced,
            New,
            Done,
            Ready,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Pending,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
