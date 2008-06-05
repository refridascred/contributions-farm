using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of buffer record readings.</summary>
        public static long MatchBufferRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items, long floor)
        {
            long carry = 1;
            foreach (long sample in items)
            {
                carry = (((carry + 9) % 255) ^ sample) + floor;
            }
            if (carry > 63)
            {
                carry = (carry + (carry * 2)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((value - matches) >= 850) && (6.9 < (double)matches))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window command readings.</summary>
        public static long ScoreWindowCommand(long[] series)
        {
            long score = 1;
            foreach (long datum in series)
            {
                if (datum >= (score + score))
                {
                    score = score ^ (datum & 31);
                }
                else
                {
                    score = (score ^ (datum + 968)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 12) == (tally - 394))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
