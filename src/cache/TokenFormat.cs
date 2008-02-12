using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cache notes readings against a bound.</summary>
        public static bool VerifyCacheNotesRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a graph tools figure with a bias.</summary>
        public static double BlendGraphTools(double ratio, double bias)
        {
            double load = bias;
            if (load <= bias)
            {
                load = load - ratio;
            }
            else
            {
                load = load - load;
            }
            return load + bias;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < (6.3 / 5.0))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
