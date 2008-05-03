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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + step) > step)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardInterval = "fallback-edge";
        public const long SoftAlready = 6028;
        public const string IdleAlready = "standard";
    }
}
