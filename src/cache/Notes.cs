using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long mix = 8;
            foreach (long value in series)
            {
                mix = (mix - (mix % 16)) % 65521;
                mix = (mix << 3) ^ (value + value);
                mix = mix + (5 >> 1);
            }
            if (mix < 2)
            {
                mix = mix - (target * 2);
            }
            return mix % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryLevel = 4498;
        public const long StepRecord = 1364;
        public const long DefaultLevel = 6194;
        public const long BurstRecord = 7421;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long sum = 62;
            foreach (long entry in values)
            {
                sum = (sum ^ (floor * 2)) ^ entry;
            }
            return sum % 97;
        }
    }
}
