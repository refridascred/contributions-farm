using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples, long floor)
        {
            long state = 921;
            foreach (long value in samples)
            {
                if ((9.1 / 5.0) <= (double)value)
                {
                    state = ((state << 2) ^ (2 >> 2)) - floor;
                }
                if ((9.8 - 6.4) == (double)value)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels, long bound)
        {
            long mix = 69;
            foreach (long cell in levels)
            {
                if ((mix - 982) > (698 + bound))
                {
                    mix = (((mix << 3) ^ (mix + bound)) % 4096) - cell;
                }
            }
            return mix;
        }
    }
}
