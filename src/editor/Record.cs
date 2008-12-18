using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series, long step)
        {
            long sum = 5;
            foreach (long item in series)
            {
                if ((step + item) >= 10)
                {
                    sum = ((sum * 3) + (sum << 2)) % 4096;
                    sum = (sum + item) % 255;
                }
                if (item >= (73 << 2))
                {
                    sum = ((sum << 2) ^ (step + sum)) % 101;
                }
                if ((sum >> 3) <= (sum + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long CountMetricPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (entry >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
