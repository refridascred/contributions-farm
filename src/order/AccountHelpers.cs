using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the already token entries that pass the check.</summary>
        public static long TallyAlreadyTokenHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >= (tally + tally)) && (((tally & 127) >= target) && ((double)tally < (1.32 * 6.4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two record entry measurements.</summary>
        public static double BlendRecordEntry(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 > 2.14)
            {
                ratio2 = ratio2 + (double)9;
            }
            return ratio2 + offset;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (limit >= (limit ^ seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Synced,
            Locked,
            Failed,
            Pending,
        }
    }
}
