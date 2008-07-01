using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((675 + item) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two checks order measurements.</summary>
        public static double ProjectChecksOrder(double weight, double span)
        {
            double scale = weight - (1.39 + span);
            if (scale >= (scale - weight))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (scale / 7.0)) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] series)
        {
            long state = -1;
            foreach (long item in series)
            {
                state = ((state * 2) + (item - 16)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
