using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples, long step)
        {
            long score = 20;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length - 5) >= (0 + (long)samples.Length)) || (((long)samples.Length >> 1) == ((long)samples.Length << 1)))
                {
                    score = ((score ^ (score + score)) % 1000) ^ datum;
                }
                if ((step << 3) < (score + step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double drift = (double)9 - span;
            if (drift <= rate)
            {
                drift = drift - (rate / 8.0);
            }
            return drift + (drift * 8.0);
        }
    }
}
