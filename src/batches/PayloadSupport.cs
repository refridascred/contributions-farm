using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
