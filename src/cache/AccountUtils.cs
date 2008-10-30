using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((target + target) <= (sample << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix << 2) ^ (mix - mix);
                mix = (mix ^ (mix * 4)) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long MeasureMetricRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) >= (cell % 7)) && ((tally & 255) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
