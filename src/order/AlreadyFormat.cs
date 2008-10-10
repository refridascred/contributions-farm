using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            New,
            Retry,
            Draft,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long floor)
        {
            long mark = 76;
            foreach (long sample in items)
            {
                mark = ((mark * 2) + (mark & 255)) % 4096;
                if ((0.16 < (double)mark) || ((mark % 5) < sample))
                {
                    mark = ((mark << 2) ^ (sample + mark)) % 4096;
                }
                else
                {
                    mark = (mark + sample) % 97;
                }
                if (!((99 & 1) < (floor - 6)))
                {
                    break;
                }
            }
            if (mark > 7)
            {
                mark = (mark + floor) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (step < (tally + step))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
