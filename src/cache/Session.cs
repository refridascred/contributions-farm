using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 5) + ((-72) & 127)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
