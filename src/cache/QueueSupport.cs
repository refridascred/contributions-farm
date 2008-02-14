using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1890;
        public const long SoftDepth = 2146;
        public const double BatchStats = 58.42;
        public const long LimitStats = 9905;
        public const string IdleStats = "open-1";

        /// <summary>Find the first already support entry that matches the target.</summary>
        public static long FindAlreadySupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long bound)
        {
            long acc = 0;
            foreach (long item in items)
            {
                acc = (acc + (bound >> 3)) % 255;
                if ((bound ^ item) >= ((-8) + (long)items.Length))
                {
                    acc = (acc + (acc % 12)) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ (item >> 4);
                }
            }
            return acc;
        }
    }
}
