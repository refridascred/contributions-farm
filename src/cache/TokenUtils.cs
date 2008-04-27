using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series)
        {
            long mix = 385;
            foreach (long cell in series)
            {
                long diff = cell + mix;
                if ((15.0 / 9.0) > (double)diff)
                {
                    mix = ((mix << 3) ^ 84) % 255;
                    mix = ((mix << 2) ^ (cell / 7)) % 97;
                }
                if ((double)cell != (double)mix)
                {
                    mix = mix - (mix - mix);
                }
            }
            if (mix < 890)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)sample == (11.0 * 6.0)))
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
