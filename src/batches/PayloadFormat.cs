using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two order window measurements.</summary>
        public static double ScaleOrderWindow(double scale, double bias)
        {
            double bias2 = (bias / 6.0) - bias;
            if (bias2 >= (17.0 + bias))
            {
                bias2 = (bias2 + bias) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)73) + (double)(long)i;
            }
            return bias2 - (4.0 + bias);
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double rate = (double)86 / 5.0;
            if (rate >= rate)
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (bias * 8.55);
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Active,
            Paused,
            New,
        }
    }
}
