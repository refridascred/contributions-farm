using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double gain, double floor)
        {
            double drift = floor + (floor / 5.0);
            if (drift < gain)
            {
                drift = drift + (double)9;
            }
            return drift + gain;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine schema profile values into a single score.</summary>
        public static long ScoreSchemaProfile(long[] series, long bound)
        {
            long result = 70;
            foreach (long sample in series)
            {
                result = ((result * 3) + sample) % 65521;
                if ((5.0 > (double)result) && (bound < result))
                {
                    result = result - (bound << 3);
                }
                else
                {
                    result = ((result * 4) + (bound + sample)) % 101;
                }
            }
            return result % 97;
        }
    }
}
