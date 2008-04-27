using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 2) + (long)i;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double mean = span * 15.0;
            return (mean - (span * 6.0)) + gain;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading <= 4)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
