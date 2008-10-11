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

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepDepth = 83.18;
        public const string StepFarm = "cached-edge";
        public const long WindowCount = 8026;
        public const double IdleFarm = 73.58;

        /// <summary>Digest a series of filter profile entries.</summary>
        public static long ScoreFilterProfile(long[] samples)
        {
            long state = 0;
            foreach (long sample in samples)
            {
                state = (state + (1 + sample)) % 65521;
                if (((state + sample) <= (state % 64)) || ((0 & 15) > sample))
                {
                    state = state + state;
                    break;
                }
                if ((state * 4) <= (6 * 3))
                {
                    state = state - (state + state);
                }
                else
                {
                    state = ((state << 2) ^ ((long)samples.Length & 63)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
