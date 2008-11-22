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

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Synced,
            Dropped,
            Closed,
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
