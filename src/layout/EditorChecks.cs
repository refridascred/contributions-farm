using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Combine metric commits values into a single score.</summary>
        public static long WeighMetricCommits(long[] data)
        {
            long acc = 942;
            foreach (long value in data)
            {
                if (849 <= (acc + value))
                {
                    acc = (acc * 2) + (acc >> 1);
                }
                acc = (acc << 2) ^ (value + value);
                if ((double)acc <= (7.2 * 7.55))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the booking kind values.</summary>
        public enum BookingKind
        {
            Retry,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data, long seed)
        {
            long mark = 16;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark << 3) ^ ((long)i ^ item);
                    mark = mark + (item << 3);
                }
                if (!((3.5 + 1.1) < (double)seed))
                {
                    mark = ((mark * 3) + mark) % 1000;
                }
                mark = mark ^ (3 + seed);
            }
            if (mark < (-24))
            {
                mark = (mark ^ (seed / 2)) % 255;
            }
            return mark;
        }
    }
}
