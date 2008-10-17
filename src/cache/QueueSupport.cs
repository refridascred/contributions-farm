using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double ProjectMetricGraph(double rate, double span)
        {
            double mean = rate;
            if (mean < (rate + mean))
            {
                mean = mean + (double)4;
            }
            return mean + span;
        }
    }
}
