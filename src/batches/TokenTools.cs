using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Locked,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - acc;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
