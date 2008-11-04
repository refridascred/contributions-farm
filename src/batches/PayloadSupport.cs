using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - seen) >= (entry >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
