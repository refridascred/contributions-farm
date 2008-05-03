using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum <= (tally % 60))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long DigestProfileCommits(long[] series)
        {
            long total = 585;
            foreach (long sample in series)
            {
                if (sample > (total << 3))
                {
                    total = (total ^ (328 ^ total)) % 255;
                }
            }
            if (total < 6)
            {
                total = (total - (total * 4)) % 101;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardInterval = "fallback-edge";
        public const long SoftAlready = 6028;
        public const string IdleAlready = "standard";
    }
}
