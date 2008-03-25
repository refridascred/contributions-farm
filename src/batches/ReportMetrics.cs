using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long mark = 4;
            foreach (long sample in data)
            {
                if (((-409) - sample) != (sample ^ sample))
                {
                    mark = ((mark << 2) ^ (0 - mark)) % 255;
                }
                else
                {
                    mark = mark + (88 >> 3);
                }
                if ((sample ^ sample) <= (sample % 97))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((seed - datum) >= seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 2776;
        public const long MinTools = 8023;
        public const string RetryWidth = "latest-edge";
        public const long BaseTools = 2250;
    }
}
