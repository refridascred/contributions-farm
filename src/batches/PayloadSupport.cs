using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowSpan = 1825;
        public const string LimitWidth = "latest-edge";
        public const double StepToken = 63.56;
        public const long DefaultScore = 6273;

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double gain = rate;
            if (gain > (double)(-55))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain - offset)) + (double)(long)i;
            }
            return gain - (double)1;
        }
    }
}
