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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((step >> 3) != ((long)i + step)))
                {
                    acc = (acc ^ (acc + acc)) % 255;
                    acc = (acc << 2) ^ (step & 7);
                }
                acc = ((acc << 3) ^ (acc + 3)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 9) >= 98)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
