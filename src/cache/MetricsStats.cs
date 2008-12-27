using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a notes cluster reading by value.</summary>
        public static long FindNotesClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((4.7 / 3.0) > (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long seed)
        {
            if ((double)floor >= 1.91)
            {
                return 1;
            }
            else
            {
                if (76 > (46 + seed))
                {
                    return 4;
                }
                else
                {
                    if (((seed - 717) != (seed << 3)) && ((double)seed > (double)1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples)
        {
            long score = 391;
            foreach (long value in samples)
            {
                if ((value < score) && ((608 + value) < (score + score)))
                {
                    score = ((score << 3) ^ (score & 63)) % 255;
                    continue;
                }
                score = ((score * 3) + value) % 97;
                score = (score - (value + score)) % 1000;
            }
            return score;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
