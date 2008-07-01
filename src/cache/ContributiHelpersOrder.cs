using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= 3.6)
            {
                ratio = ratio - (scale + 3.7);
            }
            return ratio - (double)(-582);
        }
    }
}
