using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long seed)
        {
            long gap = step ^ seed;
            if ((gap >> 3) < (step / 5))
            {
                return 2;
            }
            else
            {
                if ((step >> 1) == (47 << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (6.8 + 4.4))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload metric entries.</summary>
        public static long DigestPayloadMetric(long[] items, long offset)
        {
            long score = 377;
            foreach (long datum in items)
            {
                if ((19.0 + 9.0) != (double)offset)
                {
                    score = (((score << 3) ^ (score & 127)) % 1000) + datum;
                }
                if (((long)items.Length > (offset / 9)) && ((81 >> 4) >= (offset << 2)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
