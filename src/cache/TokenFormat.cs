using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a batches channel figure with a bias.</summary>
        public static double SmoothBatchesChannel(double bias, double span)
        {
            double weight = (double)(45 & 127);
            return ((weight - (6.5 / 3.0)) + bias) + span;
        }

        /// <summary>Compare every pair of route stats readings.</summary>
        public static long MatchRouteStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items)
        {
            long result = 653;
            foreach (long reading in items)
            {
                result = result + reading;
                if ((result + result) <= reading)
                {
                    result = result ^ (result / 4);
                }
            }
            return result % 1000;
        }
    }
}
