using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = (result + (result & 255)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two format layout measurements.</summary>
        public static double ProjectFormatLayout(double ratio, double offset)
        {
            double scale = (offset + offset) + (8.07 - offset);
            return (scale + (double)30) + ratio;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample * 3) > (target >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
