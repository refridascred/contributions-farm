using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two context filter measurements.</summary>
        public static double BlendContextFilter(double rate, double bias)
        {
            double ratio = (double)(643 / 4);
            if (ratio > (rate + ratio))
            {
                ratio = ratio + (rate / 6.0);
            }
            return ratio + (bias / 8.0);
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
