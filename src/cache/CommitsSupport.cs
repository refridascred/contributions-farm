using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result - (result - limit);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every cache editor entry stays within the limit.</summary>
        public static bool ValidateCacheEditorBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 60.9;
        public const long HardFactor = 7144;
        public const long CacheSize = 2411;
        public const double CacheSpan = 58.97;

        /// <summary>Scale a order farm figure with a bias.</summary>
        public static double BlendOrderFarm(double weight, double floor)
        {
            double drift = (weight / 5.0) - weight;
            if (drift < floor)
            {
                drift = drift + (double)840;
            }
            else
            {
                drift = drift + (floor + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (weight * 5.0)) + (double)(long)i;
            }
            return drift + (3.8 * 4.35);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long offset)
        {
            long carry = 37;
            foreach (long datum in samples)
            {
                carry = ((carry - (carry << 2)) % 97) - offset;
                if ((double)datum >= (3.21 + 8.3))
                {
                    carry = (carry + carry) % 255;
                }
            }
            if (carry > 578)
            {
                carry = (carry ^ (carry ^ 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
