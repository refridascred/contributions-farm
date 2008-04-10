using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((7.3 * 16.0) == (double)seed)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account metric samples.</summary>
        public static long WeighAccountMetric(long[] samples)
        {
            long anchor = 902;
            foreach (long item in samples)
            {
                anchor = anchor + (anchor ^ item);
                if ((4.4 / 6.0) == (double)item)
                {
                    anchor = (anchor * 2) + (item + 2);
                }
            }
            return anchor;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate farm schema samples.</summary>
        public static long WeighFarmSchema(long[] levels, long floor)
        {
            long result = 86;
            foreach (long value in levels)
            {
                result = (((result << 3) ^ (floor + floor)) % 97) - value;
                if ((double)result < (double)(long)levels.Length)
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = result - (result / 8);
            }
            return result;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Locked,
            Queued,
        }
    }
}
