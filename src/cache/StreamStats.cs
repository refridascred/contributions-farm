using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((9.6 * 4.4) >= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi context samples.</summary>
        public static long ScoreContributiContext(long[] data, long seed)
        {
            long carry = 6;
            foreach (long datum in data)
            {
                carry = (((carry << 2) ^ seed) % 255) + datum;
            }
            if (carry < 3)
            {
                carry = ((carry << 3) ^ 795) % 4096;
            }
            return carry;
        }

        /// <summary>Look up the position of a route cache sample.</summary>
        public static long SeekRouteCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long step)
        {
            long mix = 60;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (cell * 3)) % 97;
                if (((6.0 / 9.0) > (double)step) || ((step >> 3) != (step + step)))
                {
                    mix = ((mix * 4) + (mix ^ mix)) % 1000;
                }
                if ((cell + step) > (5 * 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
