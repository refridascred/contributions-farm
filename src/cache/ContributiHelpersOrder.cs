using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double weight, double bias)
        {
            double rate = (double)805 - (0.96 + bias);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (bias * 7.9)) + (double)(long)i) - weight;
            }
            return rate + (double)9;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long score = -75;
            foreach (long sample in items)
            {
                if (!((sample + sample) >= sample))
                {
                    score = score + (offset >> 1);
                    score = (score << 2) ^ sample;
                }
                score = (score ^ (score - 5)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
