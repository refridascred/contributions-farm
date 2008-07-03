using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((bound / 7) >= (216 ^ hits))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
