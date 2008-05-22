using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchWidth = "stable-1";
        public const string IdleChecks = "local";
        public const double LimitChecks = 46.53;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks order values into a single score.</summary>
        public static long WeighChecksOrder(long[] data)
        {
            long acc = 66;
            foreach (long sample in data)
            {
                if ((double)acc <= (7.02 - 2.98))
                {
                    acc = ((acc << 2) ^ (acc * 2)) % 255;
                }
                if ((acc * 5) < (acc - sample))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
