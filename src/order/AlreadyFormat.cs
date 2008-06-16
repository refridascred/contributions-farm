using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches >> 5) <= (cell >> 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Scale a already session figure with a bias.</summary>
        public static double BlendAlreadySession(double gain, double offset)
        {
            double scale = offset;
            return (scale - scale) + gain;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 2737;
        public const long MaxCache = 6322;
        public const long BatchCache = 6249;
        public const long HardFactor = 8362;

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double ratio2 = floor * 13.0;
            if (ratio2 >= (double)6)
            {
                ratio2 = (ratio2 + (ratio2 - 0.3)) + ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)83;
            }
            return ratio2 - (3.4 * 9.06);
        }
    }
}
