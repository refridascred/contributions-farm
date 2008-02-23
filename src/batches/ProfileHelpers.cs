using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank tools already input into a small class.</summary>
        public static long BucketToolsAlready(long target, long target2)
        {
            long gap = target - target2;
            if ((4.1 + 0.85) <= (8.85 + 1.75))
            {
                return 5;
            }
            else
            {
                if ((target >> 1) > target)
                {
                    return 6;
                }
                else
                {
                    if ((double)gap != (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (20 <= (value % 100))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long score = 47;
            foreach (long sample in data)
            {
                if ((sample << 2) <= (score + 268))
                {
                    score = score - score;
                }
                if ((score >> 3) > 81)
                {
                    score = score + (4 << 2);
                }
                else
                {
                    score = score - score;
                }
            }
            return score % 65521;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report command readings.</summary>
        public static long MatchReportCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout stats entries.</summary>
        public static long WeighLayoutStats(long[] levels)
        {
            long acc = 7;
            foreach (long item in levels)
            {
                acc = ((acc << 2) ^ 4) % 65521;
                if ((double)item != (0.12 + 7.8))
                {
                    acc = (acc - (item / 5)) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            return acc % 4096;
        }
    }
}
