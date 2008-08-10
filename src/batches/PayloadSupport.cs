using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long acc = 94;
            foreach (long item in items)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc ^ acc) % 1000) + (long)i2;
                }
                if ((acc > item) && ((item << 1) > item))
                {
                    acc = (acc ^ (acc + 614)) % 4096;
                }
                else
                {
                    acc = (acc ^ (item / 3)) % 65521;
                }
            }
            if (acc < 98)
            {
                acc = (acc << 3) ^ (acc ^ acc);
            }
            return acc % 4096;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
