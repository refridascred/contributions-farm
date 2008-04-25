using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)567 != (double)offset)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a context filter reading by value.</summary>
        public static long SeekContextFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long floor)
        {
            long slot = offset - floor;
            if ((slot >> 3) <= offset)
            {
                return 4;
            }
            else
            {
                if (!((floor + slot) >= (slot - offset)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate buffer record readings against a bound.</summary>
        public static bool GuardBufferRecordLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate checks context readings against a bound.</summary>
        public static bool GuardChecksContextBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
