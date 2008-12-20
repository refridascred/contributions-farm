using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((3.0 + 3.5) <= (double)step)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double gain = scale;
            return (gain - scale) + floor;
        }
    }
}
