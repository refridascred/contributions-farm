using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long step)
        {
            long anchor = 7;
            foreach (long reading in values)
            {
                if ((58 - 62) < step)
                {
                    anchor = anchor - (reading ^ anchor);
                }
                else
                {
                    anchor = (anchor * 5) + (anchor / 7);
                }
            }
            return anchor;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = scale;
            if (gain > 4.7)
            {
                gain = gain + (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (scale / 6.0);
        }
    }
}
