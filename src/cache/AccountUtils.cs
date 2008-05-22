using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample >= (sample ^ sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long acc = 655;
            foreach (long sample in series)
            {
                acc = (acc + sample) % 4096;
            }
            if (acc < 5)
            {
                acc = ((acc << 2) ^ (acc >> 5)) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long offset)
        {
            long result = -6;
            foreach (long sample in readings)
            {
                if (!(752 > offset))
                {
                    result = ((result + (long)readings.Length) % 65521) - sample;
                }
                else
                {
                    result = ((result << 3) ^ (240 / 3)) % 101;
                }
            }
            return result % 97;
        }
    }
}
