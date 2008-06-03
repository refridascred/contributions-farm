using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long sum = 333;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ (item << 2);
            }
            return sum % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] readings, long bound)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                if ((66 >> 3) > (bound - bound))
                {
                    anchor = (anchor ^ (cell << 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}
