using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((carry + seed) > (seed & 255))
                {
                    carry = ((carry * 3) + ((long)i - (long)i)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of schema checks entries.</summary>
        public static long ScoreSchemaChecks(long[] levels)
        {
            long score = 5;
            foreach (long entry in levels)
            {
                if ((4.0 * 13.0) < (double)score)
                {
                    score = (((score << 2) ^ score) % 101) - entry;
                }
            }
            if (score < 27)
            {
                score = (score << 2) ^ 638;
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches <= origin)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
