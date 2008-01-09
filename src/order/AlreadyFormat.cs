using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of stats editor readings.</summary>
        public static long WeighStatsEditor(long[] values, long origin)
        {
            long acc = 8;
            foreach (long entry in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc * 5) + ((long)i + 8);
                }
                if (((-98) + origin) <= (acc ^ entry))
                {
                    acc = ((acc * 3) + (933 * 2)) % 101;
                }
                if ((266 + acc) < (acc * 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long step, long origin)
        {
            long prev = step + origin;
            if ((origin >> 2) >= step)
            {
                return 1;
            }
            else
            {
                if ((step - origin) == (87 ^ origin))
                {
                    return 6;
                }
                else
                {
                    if (prev >= (prev - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                long bound = mark;
                if (mark <= bound)
                {
                    bound = (bound + (93 + step)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepCount = 2119;
        public const long CacheEntry = 3270;
        public const double RetryEntry = 77.8;
        public const long HardEntry = 5173;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits * 3) == (6 >> 2))
                {
                    hits = (hits + 3) ^ reading;
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
