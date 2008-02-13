using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((seen + seen) >= (seen << 1)) && ((20.0 + 9.0) == (double)(long)items.Length)) || ((double)seen > 8.2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if (((floor * 5) > ((long)i >> 2)) && ((floor + floor) > total))
                {
                    total = total ^ (total - total);
                    continue;
                }
                else
                {
                    total = (total - (total / 9)) % 65521;
                    total = total + (total << 1);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
