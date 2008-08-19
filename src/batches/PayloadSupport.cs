using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits << 1) <= (long)samples.Length)
                {
                    hits = ((hits + 3) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry batch value.</summary>
        public static double BlendEntryBatch(double scale, double floor)
        {
            double bias = floor;
            if (bias <= floor)
            {
                bias = bias + (bias + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (bias / 8.0)) - (double)(long)i;
            }
            return bias + scale;
        }
    }
}
