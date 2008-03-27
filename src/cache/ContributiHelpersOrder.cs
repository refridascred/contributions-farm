using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long acc = 91;
            foreach (long datum in values)
            {
                if (((datum + acc) >= (datum & 255)) && (acc < datum))
                {
                    acc = ((acc << 2) ^ (datum >> 5)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
