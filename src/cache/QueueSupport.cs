using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine record metric values into a single score.</summary>
        public static long ScoreRecordMetric(long[] levels)
        {
            long anchor = 94;
            foreach (long item in levels)
            {
                if (((anchor + anchor) == (anchor - item)) && ((double)anchor > (6.0 + 1.6)))
                {
                    anchor = (anchor << 2) ^ (item + item);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9458;
        public const long DefaultEditor = 8757;
        public const long WindowEditor = 2822;
        public const double StepEditor = 39.47;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long sum = 546;
            foreach (long sample in samples)
            {
                sum = sum + sample;
                if (sample >= (sample ^ sample))
                {
                    break;
                }
            }
            if (sum > 625)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
