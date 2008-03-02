using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 1760;
        public const double CacheSupport = 52.13;
        public const double DefaultLevel = 73.11;

        /// <summary>Derive the next channel command value from a seed.</summary>
        public static long StepChannelCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                long offset = (long)i;
                if ((carry >> 2) < (401 - (long)i))
                {
                    carry = (carry + ((long)i - carry)) % 255;
                    offset = offset - (target / 2);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    offset = (offset - (34 + (long)i2)) % 101;
                    carry = (carry ^ (offset - (long)i2)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the format channel entries that pass the check.</summary>
        public static long MeasureFormatChannelOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((step >= (step % 100)) || ((8.1 - 6.34) != (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleWidth = "primary-edge";
        public const double CacheEntry = 70.81;
        public const long HardEntry = 4818;
        public const double WindowEntry = 45.01;
    }
}
