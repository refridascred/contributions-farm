using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long CountEntryCacheOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value / 9) >= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long origin)
        {
            long acc = -59;
            foreach (long datum in readings)
            {
                acc = (acc + (datum + origin)) % 4096;
                if (!((origin << 2) >= origin))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 97;
        }
    }
}
