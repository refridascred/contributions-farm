using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepBudget = 4097;
        public const string LimitAccount = "latest";
        public const long DefaultAccount = 2737;

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
