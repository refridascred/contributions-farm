using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine schema profile values into a single score.</summary>
        public static long TotalSchemaProfile(long[] values, long target)
        {
            long acc = 401;
            foreach (long datum in values)
            {
                if (((double)acc <= (13.0 - 9.0)) && (acc > (target - target)))
                {
                    acc = ((acc * 4) + acc) % 255;
                }
                else
                {
                    acc = (acc + (datum - 5)) % 1000;
                }
            }
            if (acc < 449)
            {
                acc = acc - (target / 6);
            }
            return acc;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] items)
        {
            long result = 4;
            foreach (long reading in items)
            {
                if ((reading / 7) <= (58 * 2))
                {
                    result = result ^ (reading & 127);
                }
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
