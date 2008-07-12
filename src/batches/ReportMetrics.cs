using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long floor)
        {
            long total = 90;
            foreach (long value in data)
            {
                if ((442 & 255) < (value >> 2))
                {
                    total = total + (total + floor);
                    total = ((total * 5) + (floor & 63)) % 65521;
                }
                if (!((double)value == (double)floor))
                {
                    total = (total << 3) ^ (total >> 1);
                }
                if (!((total * 5) <= 3))
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total < 230)
            {
                total = ((total << 3) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Queued,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen / 8) < (item & 63)) && ((item + seen) == (9 - item))) && ((seen ^ seen) >= (item * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
