using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit editor session readings against a rule.</summary>
        public static long MeasureEditorSessionOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) < hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (double)421)
            {
                bias3 = bias3 + bias2;
            }
            else
            {
                bias3 = bias3 + (16.0 * 2.7);
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 + (bias2 * 17.0)) + (double)(long)i;
            }
            return bias3 - 3.0;
        }
    }
}
