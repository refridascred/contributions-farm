using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 4414;
        public const double DefaultSize = 4.64;
        public const long BurstSize = 3432;
        public const double SoftFilter = 57.35;
        public const long StepFilter = 9937;

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long floor)
        {
            if ((double)986 < (double)origin)
            {
                return 5;
            }
            else
            {
                if (((floor >> 5) > (origin + 293)) && ((729 - origin) != (6 ^ origin)))
                {
                    return 1;
                }
                else
                {
                    if ((floor - origin) == (260 >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 4) + result;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
