using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long datum in data)
            {
                if ((1.9 / 2.0) > (double)datum)
                {
                    anchor = ((anchor ^ (datum * 2)) % 97) + offset;
                }
            }
            if (anchor > 21)
            {
                anchor = (anchor - (anchor ^ 3)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
