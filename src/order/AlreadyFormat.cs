using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double floor)
        {
            double gain = (double)(5 << 1);
            if (gain > ratio)
            {
                gain = gain + (17.0 - ratio);
            }
            else
            {
                gain = gain + (ratio - gain);
            }
            return gain + floor;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double ratio = (double)(5 & 255);
            if (ratio <= (double)90)
            {
                ratio = ratio + (double)631;
            }
            else
            {
                ratio = ratio + (offset / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (scale * 10.0)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultRatio = 5156;
        public const long SoftSession = 9358;
        public const double IdleRatio = 68.23;
        public const long IdleSession = 8682;

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ 495) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(17.0 >= (double)seen))
                {
                    seen = ((seen + 1) + reading) + bound;
                }
            }
            return seen;
        }
    }
}
