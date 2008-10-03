using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings)
        {
            long total = 1;
            foreach (long datum in readings)
            {
                if (((total & 255) > (datum / 7)) || ((4 & 7) <= datum))
                {
                    total = (total + (datum - 94)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long origin)
        {
            long mix = 944;
            foreach (long cell in levels)
            {
                mix = ((mix << 2) ^ (mix - 2)) % 1000;
                mix = ((mix << 3) ^ cell) % 101;
                if ((1 % 3) > mix)
                {
                    mix = (mix ^ (cell - origin)) % 101;
                }
            }
            if (mix > 6)
            {
                mix = (mix - (mix ^ origin)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
