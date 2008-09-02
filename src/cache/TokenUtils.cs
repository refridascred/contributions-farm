using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double span)
        {
            double drift = scale;
            if (drift > (span * 2.0))
            {
                drift = drift + (span - 6.09);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
