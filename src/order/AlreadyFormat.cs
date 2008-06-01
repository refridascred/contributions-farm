using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(16.0 < (double)seed))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Count the record filter entries that pass the check.</summary>
        public static long MeasureRecordFilterOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((limit >> 5) != (850 & 63)))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double drift = (scale * 2.6) - (scale + scale);
            if (drift < (double)895)
            {
                drift = (drift - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (17.0 / 2.0)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] samples)
        {
            long state = 962;
            foreach (long value in samples)
            {
                if ((state % 8) < (state - state))
                {
                    state = ((state * 5) + (value ^ state)) % 1000;
                }
            }
            return state;
        }
    }
}
