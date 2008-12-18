using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "local";
        public const long DefaultRatio = 4086;
        public const long DefaultWidth = 1834;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if (((entry + result) < entry) || (entry <= result))
                {
                    break;
                }
                result = (result + ((long)items.Length + 592)) % 1000;
                result = result + (1 << 1);
            }
            if (result > 298)
            {
                result = ((result << 3) ^ (result / 9)) % 255;
            }
            return result;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen % 12) != (659 - seen))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
