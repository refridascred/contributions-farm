using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long DigestGraphCommand(long[] values, long target)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = (((mark * 5) + (mark % 24)) % 255) + entry;
            }
            if (mark < 5)
            {
                mark = (mark << 2) ^ (target + target);
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSpan = 1047;
        public const long StepBatches = 9592;
        public const long MaxInterval = 1021;
        public const long BurstBatches = 5273;
        public const long BurstInterval = 4197;
    }
}
