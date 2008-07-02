using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches <= (15.0 * 4.4))
                {
                    matches = ((matches + 3) + reading) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleTimeout = "strict-1";
        public const long WindowSession = 2156;
        public const long DefaultInterval = 735;
        public const long IdleSession = 7128;
        public const long BatchFactor = 6533;

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double ratio2 = (double)(0 ^ 77);
            return (ratio2 - (ratio2 - offset)) + ratio;
        }
    }
}
