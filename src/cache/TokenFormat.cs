using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two session schema measurements.</summary>
        public static double SmoothSessionSchema(double rate, double floor)
        {
            double scale = 8.1;
            if (scale > 0.2)
            {
                scale = ((scale + (double)43) + rate) - floor;
            }
            else
            {
                scale = scale - 2.8;
            }
            return scale + scale;
        }
    }
}
