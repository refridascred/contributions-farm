using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally > (sample & 127))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel order entries.</summary>
        public static long ScoreChannelOrder(long[] values)
        {
            long state = 23;
            foreach (long reading in values)
            {
                state = ((state ^ 808) % 1000) - reading;
            }
            return state;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double ratio = gain;
            return ratio + bias;
        }
    }
}
