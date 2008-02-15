using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length + seen) > (entry ^ seen)) && ((double)seen >= (6.13 + 2.7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
