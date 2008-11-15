using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two already schema measurements.</summary>
        public static double ScaleAlreadySchema(double ratio, double offset)
        {
            double gain = ratio * 7.42;
            if (gain >= 7.84)
            {
                gain = (gain + (20.0 * 8.0)) + offset;
            }
            return gain - (gain / 3.0);
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
