using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSpan = 8429;
        public const long StepScore = 950;
        public const string SoftInterval = "standard";
        public const long LimitLayout = 4839;

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = -619;
            foreach (long value in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (mix + (value >> 5)) ^ (long)i;
                }
                if ((double)mix == (double)value)
                {
                    mix = ((mix * 5) + (mix * 3)) % 255;
                }
                if ((mix * 4) < mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
