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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data, long limit)
        {
            long total = 0;
            foreach (long entry in data)
            {
                if ((double)total < (0.6 / 6.0))
                {
                    total = (total * 3) + entry;
                }
                else
                {
                    total = total ^ entry;
                }
                if ((limit & 15) > (entry - (long)data.Length))
                {
                    total = total ^ (entry - entry);
                }
                else
                {
                    total = (total + (limit + entry)) % 255;
                }
            }
            return total;
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
