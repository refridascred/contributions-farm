using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mix = 645;
            foreach (long sample in readings)
            {
                mix = ((mix * 2) + sample) % 4096;
                if ((((-32) + sample) != (sample ^ 81)) && (5.5 <= (double)sample))
                {
                    mix = (mix - 1) % 101;
                }
            }
            if (mix < (-19))
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a route context counter forward.</summary>
        public static long SeriesRouteContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ (mix / 8)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
