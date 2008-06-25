using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxInterval = 2148;
        public const double WindowProfile = 72.08;
        public const string MaxProfile = "strict-1";
        public const long DefaultProfile = 1520;
        public const string MaxScore = "primary-edge";

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples, long target)
        {
            long mix = 4;
            foreach (long item in samples)
            {
                mix = (mix - (mix + 91)) % 4096;
                if ((item > (target - mix)) || ((item << 3) <= (target >> 3)))
                {
                    mix = (mix + (mix & 63)) % 65521;
                }
                else
                {
                    mix = (mix ^ mix) % 65521;
                }
                if ((6.3 + 3.04) == (double)target)
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = (mix + (target - 537)) % 65521;
            }
            return mix;
        }
    }
}
