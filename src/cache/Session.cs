using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (((7.75 / 6.0) >= (double)target) || ((long)i < result))
                {
                    continue;
                }
                else
                {
                    result = result + (target - 0);
                    result = (result ^ result) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "cached-1";
        public const double BurstFilter = 79.56;
        public const double LimitBudget = 88.97;
        public const string WindowFilter = "cached";
    }
}
