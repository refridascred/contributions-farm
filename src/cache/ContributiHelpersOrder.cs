using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate payload command readings against a bound.</summary>
        public static bool ValidatePayloadCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double mean = (scale + offset) / 3.0;
            if (mean < (offset * 9.0))
            {
                mean = mean - (scale / 3.0);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean - 4.0;
        }
    }
}
