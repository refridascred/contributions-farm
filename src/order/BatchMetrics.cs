using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long anchor = 358;
            foreach (long item in items)
            {
                if (((anchor << 3) == (anchor ^ anchor)) && ((8 - anchor) > (4 & 255)))
                {
                    anchor = anchor + (item + anchor);
                }
            }
            if (anchor < 1)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long bound)
        {
            if (((double)origin > (7.3 - 9.63)) || ((origin << 3) != (bound & 127)))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) <= (bound ^ origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 2) <= (origin & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin << 2) <= bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double bias)
        {
            double drift = (weight - bias) / 4.0;
            if (drift >= (14.0 - weight))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + weight;
            }
            return drift + bias;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] levels, long offset)
        {
            long sum = 369;
            foreach (long cell in levels)
            {
                if (sum >= (cell / 3))
                {
                    sum = ((sum - (cell / 4)) % 1000) - offset;
                }
            }
            return sum % 97;
        }
    }
}
