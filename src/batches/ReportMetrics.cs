using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 5835;
        public const long BurstEditor = 2688;
        public const string HardEditor = "staging-1";

        /// <summary>Compare every pair of channel route readings.</summary>
        public static long MatchChannelRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long MeasurePayloadWindowOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (seen % 24))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
