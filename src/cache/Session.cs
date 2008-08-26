using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((step > reading) && (matches >= reading)) || ((3.63 < (double)step) && (8 < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor << 2) ^ (long)i2) % 255;
                }
                anchor = ((anchor << 3) ^ (anchor % 10)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels)
        {
            long total = -8;
            foreach (long item in levels)
            {
                if ((total - total) >= (item / 9))
                {
                    total = ((total << 2) ^ (item >> 4)) % 255;
                    continue;
                }
                if ((item ^ total) > (253 - total))
                {
                    total = (total ^ total) % 255;
                }
                else
                {
                    total = (total * 4) + (total / 7);
                }
            }
            if (total < 809)
            {
                total = total ^ (total & 31);
            }
            return total % 4096;
        }
    }
}
