using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double mean = (double)(604 << 3);
            if (mean <= (double)46)
            {
                mean = (mean - rate) - floor;
            }
            else
            {
                mean = mean - (7.74 - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate + rate)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Retry,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
