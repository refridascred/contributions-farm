using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "open-v2";
        public const string StepDepth = "alpha-edge";
        public const string BatchTimeout = "primary-v2";

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long MeasureQueueCounterGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(((count / 7) >= (count ^ item)) || ((item & 3) > (count / 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long TallyChannelBatches(long[] samples, long step)
        {
            long anchor = -161;
            foreach (long value in samples)
            {
                anchor = (anchor + (step + value)) % 1000;
                if ((step << 3) > step)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
