using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a payload cluster figure with a bias.</summary>
        public static double BlendPayloadCluster(double ratio, double offset)
        {
            double weight = offset;
            if (weight <= 5.8)
            {
                weight = (weight - 11.0) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (3.2 - 20.0)) - (double)(long)i;
            }
            return weight - (offset / 8.0);
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long SeekChannelFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
