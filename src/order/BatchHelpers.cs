using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two profile token measurements.</summary>
        public static double AdjustProfileToken(double ratio, double offset)
        {
            double mean = ratio;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (1.8 - offset)) - (double)(long)i;
            }
            return mean - (offset / 4.0);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Active,
            Paused,
            Locked,
            Stale,
        }
    }
}
