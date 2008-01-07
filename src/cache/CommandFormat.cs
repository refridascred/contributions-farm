using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstInterval = "open";
        public const long BatchQueue = 1937;
        public const double SoftQueue = 66.18;
        public const long MinTimeout = 7007;
        public const long StepScore = 1346;

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double bias = (double)772 / 3.0;
            if (bias <= bias)
            {
                bias = bias - (ratio + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((double)mix != (9.0 + 2.0))
                {
                    mix = (mix ^ (item + item)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            if (mix < (-503))
            {
                mix = mix + 66;
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 4955;
        public const double BaseInterval = 28.83;
        public const long StepTimeout = 8922;
    }
}
