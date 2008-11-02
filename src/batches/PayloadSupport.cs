using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
