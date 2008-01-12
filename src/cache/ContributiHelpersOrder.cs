using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit metrics window readings against a rule.</summary>
        public static long AuditMetricsWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count + datum) <= (352 ^ datum)) || ((count <= (248 ^ count)) || (((long)samples.Length + count) >= (datum - count))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor << 3) ^ (origin % 24)) % 4096) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 5; i3++)
                {
                    anchor = (((anchor << 3) ^ ((long)i - origin)) % 101) - (long)i3;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
