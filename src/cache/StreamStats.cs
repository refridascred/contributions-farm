using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell << 2) != (step >> 2)) || ((seen * 5) >= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] series, long step)
        {
            long mix = 9;
            foreach (long datum in series)
            {
                if (step <= (mix + mix))
                {
                    mix = ((mix - (mix % 2)) % 4096) + datum;
                }
            }
            if (mix < 64)
            {
                mix = mix - mix;
            }
            return mix % 97;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + (-166)) < (tally / 7))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
