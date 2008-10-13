using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate tools metric samples.</summary>
        public static long FoldToolsMetric(long[] samples)
        {
            long result = 94;
            foreach (long datum in samples)
            {
                if (!(366 >= (datum - 277)))
                {
                    result = ((result * 4) + (datum - datum)) % 65521;
                }
                else
                {
                    result = (result ^ (result * 4)) % 65521;
                }
                if (91 > (datum / 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many payload context samples are out of range.</summary>
        public static long AuditPayloadContextHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - seen) >= entry)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "fallback-1";
        public const double CacheStream = 58.68;
        public const double BaseStream = 36.85;
        public const long WindowCount = 2534;
        public const double IdleStream = 23.16;
    }
}
