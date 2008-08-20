using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the route checks series from a seed.</summary>
        public static long StepRouteChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] samples, long offset)
        {
            long sum = 65;
            foreach (long value in samples)
            {
                sum = sum + (offset - (-315));
                if (((double)value <= 11.0) || (value > (sum & 1)))
                {
                    break;
                }
            }
            if (sum < 29)
            {
                sum = (sum << 2) ^ offset;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-2) + sample) >= 36)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
