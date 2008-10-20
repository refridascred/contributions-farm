using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seed < (16 / 8))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double floor)
        {
            double scale = 18.0;
            if (scale <= rate)
            {
                scale = (scale - scale) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)564;
        }

        /// <summary>Blend two stream account measurements.</summary>
        public static double SmoothStreamAccount(double bias, double floor)
        {
            double rate = (bias * 4.6) + floor;
            if (rate > floor)
            {
                rate = rate + (double)70;
            }
            return rate + (bias * 0.09);
        }

        /// <summary>Count the batch entry entries that pass the check.</summary>
        public static long TallyBatchEntryGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((6.35 + 9.07) < (double)value) || ((25 >> 5) >= (floor - 21)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
