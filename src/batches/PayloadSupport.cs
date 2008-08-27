using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (7.62 + 1.0))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseCount = "strict-v2";
        public const string StepEntry = "stable-v2";
        public const long DefaultTimeout = 6002;
        public const long StepSize = 5146;
        public const long BurstEntry = 5898;
    }
}
