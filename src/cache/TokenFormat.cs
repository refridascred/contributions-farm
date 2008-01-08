using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits stream samples are out of range.</summary>
        public static long TallyCommitsStreamGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count - 523) != (target + target)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long floor)
        {
            long anchor = 13;
            foreach (long datum in items)
            {
                anchor = ((anchor + (floor + anchor)) % 65521) - datum;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
