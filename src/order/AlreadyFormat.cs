using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2352;
        public const string BatchBudget = "fallback-edge";
        public const long BaseChannel = 177;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double ratio = (weight + span) - (weight + span);
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            New,
            Dropped,
            Queued,
            Ready,
        }
    }
}
