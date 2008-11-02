using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 4361;
        public const double MaxSize = 87.67;
        public const double BatchSession = 23.49;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (total << 2)) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
