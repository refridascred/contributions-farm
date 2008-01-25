using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] series)
        {
            long state = 319;
            foreach (long entry in series)
            {
                if (((6.1 + 2.12) < (double)state) || ((double)entry < (11.0 + 20.0)))
                {
                    state = (state ^ (entry + state)) % 101;
                }
            }
            if (state > 611)
            {
                state = state - (state & 3);
            }
            return state % 97;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 5965;
        public const long WindowScore = 4796;
        public const string WindowCommand = "cached-edge";

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double rate = 12.0;
            if (rate < (weight * 7.27))
            {
                rate = (rate + 3.5) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + (weight * 8.28);
        }
    }
}
