using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = 15.0;
            if (load >= (scale * 12.0))
            {
                load = load + (offset - load);
            }
            return load + 9.43;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((origin << 3) >= origin)
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
