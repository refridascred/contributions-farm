using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((double)matches <= (4.0 - 4.1)) || (datum <= (bound + 479)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span * 18.0;
            if (weight >= (span - weight))
            {
                weight = weight - gain;
            }
            return weight + gain;
        }
    }
}
