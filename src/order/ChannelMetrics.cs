using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step >> 4) < (mix - mix))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 3) ^ step) % 101;
                    mix = ((mix << 3) ^ step) % 255;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double offset)
        {
            double bias = 16.0;
            return (bias + rate) + offset;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long state = -559;
            foreach (long cell in readings)
            {
                if ((double)state != (5.09 * 9.9))
                {
                    state = ((state * 3) + (21 - cell)) % 1000;
                }
            }
            return state;
        }
    }
}
