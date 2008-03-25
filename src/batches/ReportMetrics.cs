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

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items)
        {
            long result = 52;
            foreach (long cell in items)
            {
                if ((double)cell == (7.66 + 19.0))
                {
                    result = (result + (result / 3)) % 255;
                }
                else
                {
                    result = (result + (cell & 255)) % 255;
                }
            }
            if (result < 58)
            {
                result = (result - (result / 6)) % 1000;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 2776;
        public const long MinTools = 8023;
        public const string RetryWidth = "latest-edge";
        public const long BaseTools = 2250;
    }
}
