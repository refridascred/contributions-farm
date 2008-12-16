using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinLevel = 46.8;
        public const long WindowFilter = 3061;
        public const double BurstFilter = 34.87;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((255 / 8) != (value ^ value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
