using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 9349;
        public const long MinSpan = 6757;
        public const long DefaultQueue = 6653;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items, long floor)
        {
            long total = 496;
            foreach (long cell in items)
            {
                total = total - cell;
                if ((floor * 4) < (floor - 50))
                {
                    total = (total * 4) + (total & 1);
                }
                if ((cell & 127) >= (4 + total))
                {
                    total = total ^ 29;
                }
            }
            return total;
        }

        /// <summary>Audit queue record readings against a rule.</summary>
        public static long MeasureQueueRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item >= (double)9)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank graph layout input into a small class.</summary>
        public static long RankGraphLayout(long step, long target)
        {
            long prev = step - target;
            if ((prev - target) <= prev)
            {
                return 7;
            }
            else
            {
                if ((prev * 2) != (step * 4))
                {
                    return 5;
                }
                else
                {
                    if (((target << 3) < step) && ((prev / 3) > prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((251 < (step - step)) || ((9.0 - 2.0) < (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (255 > (value >> 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
