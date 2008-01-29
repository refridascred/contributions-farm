using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] series, long seed)
        {
            long anchor = 80;
            foreach (long cell in series)
            {
                if (seed >= (8 - anchor))
                {
                    anchor = ((anchor * 4) + (cell * 4)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor ^ seed)) % 101;
                }
                if ((double)seed < (0.4 + 1.38))
                {
                    break;
                }
            }
            if (anchor > 322)
            {
                anchor = ((anchor * 2) + (anchor % 97)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 73.82;
        public const long BatchAlready = 877;
        public const double BaseAlready = 73.95;

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 91.97;
        public const long DefaultToken = 7203;
        public const double BatchScore = 22.96;
        public const double LimitLevel = 4.26;
        public const string LimitTimeout = "staging-1";
    }
}
