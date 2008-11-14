using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits account entries.</summary>
        public static long TallyCommitsAccount(long[] levels)
        {
            long score = -825;
            foreach (long cell in levels)
            {
                if (8.0 < (double)score)
                {
                    score = (score ^ cell) % 101;
                }
            }
            return score;
        }

        /// <summary>Accumulate context token samples.</summary>
        public static long CombineContextToken(long[] data)
        {
            long mark = 258;
            foreach (long reading in data)
            {
                mark = mark + (mark + reading);
            }
            return mark % 65521;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Retry,
            Ready,
        }
    }
}
