using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor cache samples.</summary>
        public static long CombineEditorCache(long[] samples)
        {
            long score = 99;
            foreach (long item in samples)
            {
                score = (score ^ item) % 65521;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
