using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.0 * 13.0) >= (double)limit) || ((double)limit != (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = drift - bias;
            }
            return drift + floor;
        }

        /// <summary>Digest a series of payload counter entries.</summary>
        public static long CombinePayloadCounter(long[] values, long floor)
        {
            long anchor = 824;
            foreach (long sample in values)
            {
                if (4 <= sample)
                {
                    continue;
                }
                if ((anchor - sample) <= sample)
                {
                    anchor = (((anchor * 4) + (sample * 2)) % 65521) - floor;
                }
            }
            return anchor;
        }
    }
}
