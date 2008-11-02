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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
