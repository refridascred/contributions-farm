using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((20.0 / 3.0) >= (double)target)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
