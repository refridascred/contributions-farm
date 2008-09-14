using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 20.53;
        public const long MinBatch = 2517;
        public const long BurstLevel = 5000;

        /// <summary>Compare every pair of notes cache readings.</summary>
        public static long MatchNotesCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double rate = 3.0;
            if (rate > span)
            {
                rate = rate + (rate * 9.7);
            }
            return rate - scale;
        }
    }
}
