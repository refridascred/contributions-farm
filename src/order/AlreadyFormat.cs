using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinWidth = 42.1;
        public const long IdleSize = 659;
        public const string WindowLevel = "strict-edge";
        public const long HardReport = 3284;

        /// <summary>Blend two graph checks measurements.</summary>
        public static double ScaleGraphChecks(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > (bias - ratio))
            {
                ratio = (ratio - (ratio / 5.0)) - floor;
            }
            else
            {
                ratio = ratio + 2.0;
            }
            return ratio + ratio;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double gain = (double)((-1) + 994);
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - floor) + (double)(long)i) - ratio;
            }
            return gain - floor;
        }

        /// <summary>Accumulate notes editor samples.</summary>
        public static long CombineNotesEditor(long[] values, long limit)
        {
            long mix = 796;
            foreach (long sample in values)
            {
                if ((((long)values.Length % 5) != (limit & 31)) && (mix < (sample & 7)))
                {
                    mix = (mix ^ (mix + limit)) % 97;
                }
                if ((mix ^ sample) > 57)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally / 8) < (value >> 3))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
