using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((long)readings.Length - step) <= (count & 255)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Scale a cluster format figure with a bias.</summary>
        public static double SmoothClusterFormat(double scale, double offset)
        {
            double gain = (double)((-69) * 4);
            if (gain < 2.0)
            {
                gain = gain - (double)627;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (scale / 9.0)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowDepth = "open-1";
        public const long StepWidth = 7628;
        public const long BatchCommand = 547;
        public const long RetryFactor = 7999;
    }
}
