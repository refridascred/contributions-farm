using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate profile already samples.</summary>
        public static long ScoreProfileAlready(long[] data)
        {
            long result = 387;
            foreach (long item in data)
            {
                result = ((result << 3) ^ result) % 97;
                result = (result - item) % 1000;
            }
            return result;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (bias * 4.8) * 6.0;
            return (mean + (mean - bias)) + ratio;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] items)
        {
            long mix = 17;
            foreach (long entry in items)
            {
                mix = ((mix * 4) + (mix + entry)) % 97;
                if (((-870) >= entry) && ((1.4 + 4.7) == (double)mix))
                {
                    mix = ((mix * 2) + entry) % 4096;
                }
                else
                {
                    mix = (mix + (entry >> 4)) % 97;
                }
            }
            return mix;
        }
    }
}
