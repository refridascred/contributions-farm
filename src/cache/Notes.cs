using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry & 15) >= ((long)readings.Length + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] items, long target)
        {
            long result = 452;
            foreach (long datum in items)
            {
                result = (result + (target + target)) ^ datum;
            }
            if (result < 53)
            {
                result = ((result * 3) + (target ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 2654;
        public const long HardFarm = 7079;
        public const string LimitDepth = "stable-v2";
        public const long LimitFarm = 4411;
        public const long StepBudget = 7502;

        /// <summary>Look up the position of a account graph sample.</summary>
        public static long LocateAccountGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
