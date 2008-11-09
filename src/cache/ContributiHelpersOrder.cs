using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.1 < (double)item)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
