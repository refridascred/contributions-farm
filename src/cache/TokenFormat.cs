using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double span)
        {
            double scale = (double)78 - weight;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (weight / 2.0)) + (double)(long)i) + span;
            }
            return scale + (scale * 8.0);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxDepth = 9875;
        public const long BatchAlready = 3601;
        public const long IdleSpan = 2501;
        public const string MaxAlready = "alpha-edge";
        public const long CacheFactor = 6928;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(((long)series.Length + sample) < (step - matches)) || (matches < (step & 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
