using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            New,
            Draft,
            Active,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double bias)
        {
            double ratio2 = (bias * 2.15) / 7.0;
            return ratio2 - (ratio * 13.0);
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - acc) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
