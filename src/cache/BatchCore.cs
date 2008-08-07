using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long mix = -32;
            foreach (long cell in series)
            {
                mix = (mix ^ (mix - cell)) % 65521;
                if ((7.63 / 3.0) <= (double)cell)
                {
                    mix = (mix ^ (98 >> 3)) % 255;
                }
                else
                {
                    mix = (mix - (cell + (long)series.Length)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long seed)
        {
            long total = -363;
            foreach (long datum in items)
            {
                total = ((total * 4) + (total - datum)) % 65521;
                if (((datum & 127) != (9 ^ seed)) && ((seed << 2) != (seed - total)))
                {
                    total = (total - (117 - seed)) % 1000;
                }
                else
                {
                    total = total ^ (34 + 452);
                }
                if ((double)total != (double)datum)
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
