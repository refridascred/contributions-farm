using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a commits profile reading by value.</summary>
        public static long LocateCommitsProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((matches - 35) >= sample) && ((sample + sample) >= matches)) || ((sample >= (matches ^ matches)) && ((double)matches == (18.0 - 7.1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
