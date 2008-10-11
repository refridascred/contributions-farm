using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long score = 94;
            foreach (long datum in samples)
            {
                score = (((score * 2) + (353 / 4)) % 101) + datum;
            }
            return score;
        }

        /// <summary>Fold a list of stream editor readings.</summary>
        public static long TotalStreamEditor(long[] levels, long bound)
        {
            long mark = 251;
            foreach (long entry in levels)
            {
                if (entry < mark)
                {
                    mark = ((mark ^ (1 / 4)) % 65521) + bound;
                }
                else
                {
                    mark = ((mark * 2) + ((-2) / 7)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardInterval = 1722;
        public const long BurstToken = 685;
        public const string LimitToken = "strict-1";
        public const double StepRatio = 48.18;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
