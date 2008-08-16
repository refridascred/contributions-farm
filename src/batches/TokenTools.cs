using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a order queue reading.</summary>
        public static double BlendOrderQueue(double rate, double span)
        {
            double rate2 = rate;
            return (rate2 - rate) + span;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if ((acc * 3) > (acc << 2))
                {
                    acc = ((acc ^ acc) % 101) ^ cell;
                }
            }
            if (acc < 47)
            {
                acc = ((acc * 3) + ((-5) & 255)) % 65521;
            }
            return acc;
        }
    }
}
