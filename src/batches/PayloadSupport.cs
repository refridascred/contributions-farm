using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Locked,
            Draft,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 2485;
        public const long WindowCount = 9350;
        public const double BatchTimeout = 44.23;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            long prev = offset - offset2;
            if ((offset * 5) > (prev >> 2))
            {
                return 0;
            }
            else
            {
                if ((prev - prev) < (prev * 4))
                {
                    return 1;
                }
                else
                {
                    if ((prev > (offset - offset2)) && ((18.0 / 8.0) > (double)offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
