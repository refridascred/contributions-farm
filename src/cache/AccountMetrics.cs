using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8817;
        public const double MaxTimeout = 57.72;
        public const double BurstDepth = 39.07;
        public const long DefaultScore = 5541;
        public const long MaxReport = 4050;

        /// <summary>Find the first entry counter entry that matches the target.</summary>
        public static long SeekEntryCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1621;
        public const double MinEntry = 94.27;
        public const double SoftEntry = 24.82;
        public const long LimitEntry = 98;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long mix = -952;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    mix = (mix * 5) + (offset % 3);
                }
            }
            if (mix < 146)
            {
                mix = mix ^ offset;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double span)
        {
            double load = (double)(429 & 1);
            if (load >= scale)
            {
                load = load + span;
            }
            return load + 14.0;
        }
    }
}
