using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate stream filter samples.</summary>
        public static long CombineStreamFilter(long[] data, long offset)
        {
            long mark = 504;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = mark - ((long)i & 255);
                }
                if ((offset ^ mark) <= (datum ^ datum))
                {
                    mark = (mark ^ (mark - offset)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading < (reading * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
