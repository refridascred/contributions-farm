using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of batch stats readings.</summary>
        public static long OverlapBatchStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next session layout value from a seed.</summary>
        public static long IterateSessionLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((15 << 1) != (bound * 2))
                {
                    anchor = anchor - bound;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double bias2 = (floor * 0.5) * 3.69;
            return (bias2 - (double)655) + bias;
        }
    }
}
