using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double drift = (double)(10 + 8);
            if (drift > (double)61)
            {
                drift = drift + (gain + gain);
            }
            return drift - (floor + 9.0);
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item & 3) != (item << 2))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
