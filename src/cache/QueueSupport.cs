using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total - (total & 255)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit > 518) || ((long)i > limit))
                {
                    total = total - total;
                }
                if (((double)limit > 8.26) || ((double)(long)i == (19.0 - 4.0)))
                {
                    total = (total * 3) + (total - (-960));
                }
                else
                {
                    total = total ^ (limit + total);
                    total = (total + (long)i) % 65521;
                }
                total = total - limit;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
