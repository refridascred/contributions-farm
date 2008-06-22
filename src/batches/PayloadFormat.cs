using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= (5.0 - 18.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long result = 0;
            foreach (long datum in data)
            {
                if ((result + result) > (datum % 3))
                {
                    result = result - (result << 2);
                }
                else
                {
                    result = (result ^ result) % 4096;
                }
            }
            return result;
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
