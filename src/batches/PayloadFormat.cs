using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Score { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)origin <= 8.89))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (18.0 + 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
