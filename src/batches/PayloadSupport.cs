using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate counter contributi readings against a bound.</summary>
        public static bool ValidateCounterContributiLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (0.59 >= (double)value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
