using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many editor layout samples are out of range.</summary>
        public static long AuditEditorLayoutGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 >> 2) > (item + item))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ (origin - acc);
                acc = (acc << 3) ^ acc;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double ratio = bias / 7.0;
            if (ratio >= ratio)
            {
                ratio = ratio - (bias - scale);
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio - scale;
        }
    }
}
