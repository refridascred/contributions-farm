using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data, long offset)
        {
            long mark = 5;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark << 3) ^ (item % 64)) + offset;
                    mark = ((mark * 3) + ((long)i + mark)) % 1000;
                }
                mark = (mark + (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
