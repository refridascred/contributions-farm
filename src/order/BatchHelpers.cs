using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double floor)
        {
            double weight = gain + (floor / 9.0);
            return weight + gain;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (24 <= (matches >> 3))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor + ((long)i2 >> 2)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
