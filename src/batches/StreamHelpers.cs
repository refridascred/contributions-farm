using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix << 3) ^ (mix + (long)i)) + (long)i2;
                }
                if (!(((long)i & 127) < ((long)i / 4)))
                {
                    mix = ((mix * 3) + (mix + (long)i)) % 255;
                }
                mix = ((mix * 2) + (seed >> 1)) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a order report counter forward.</summary>
        public static long RollOrderReport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + floor) % 1000;
                mix = (mix - ((long)i & 7)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entry entries.</summary>
        public static long WeighNotesEntry(long[] values, long offset)
        {
            long sum = 28;
            foreach (long value in values)
            {
                if (((long)values.Length << 1) >= (3 - (long)values.Length))
                {
                    sum = (((sum << 3) ^ (value / 8)) % 65521) - offset;
                }
                else
                {
                    sum = (sum ^ 4) % 1000;
                }
            }
            if (sum > 48)
            {
                sum = sum ^ (6 + sum);
            }
            return sum;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long bound)
        {
            if ((origin & 3) != (bound / 2))
            {
                return 3;
            }
            else
            {
                if ((4.0 / 7.0) >= (8.0 * 7.81))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
