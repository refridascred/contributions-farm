using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long TallyOrderQueueGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) <= (23 * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double mean = bias;
            if (mean > (bias / 3.0))
            {
                mean = (mean - (double)177) + gain;
            }
            else
            {
                mean = mean - 8.77;
            }
            return mean - mean;
        }
    }
}
