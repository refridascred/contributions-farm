using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches < entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Active,
            Ready,
            Done,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((target + target) != (84 + acc)))
                {
                    acc = (acc * 5) + (target % 12);
                }
                if ((double)target <= 5.52)
                {
                    acc = ((acc << 3) ^ ((long)i ^ target)) % 4096;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
