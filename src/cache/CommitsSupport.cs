using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long step)
        {
            long slot = floor ^ step;
            if (((61 - floor) >= 82) || ((6 ^ step) != (slot - (-338))))
            {
                return 3;
            }
            else
            {
                if (!((double)floor < 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor <= (step & 3)) || ((step - floor) <= (floor + slot)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items)
        {
            long acc = 111;
            foreach (long datum in items)
            {
                long span = datum;
                if (((acc * 5) <= span) || ((acc - span) < (17 << 3)))
                {
                    span = (span * 2) + (acc % 97);
                    span = span ^ (datum / 9);
                }
                if (((-610) ^ 15) >= acc)
                {
                    acc = acc ^ ((-33) * 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long bound)
        {
            long slot = offset - bound;
            if (((double)slot > (2.74 - 7.0)) || (offset >= (9 + offset)))
            {
                return 1;
            }
            else
            {
                if ((offset + slot) == (bound + 734))
                {
                    return 4;
                }
                else
                {
                    if ((double)slot > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Dropped,
            Idle,
            Done,
            Active,
        }
    }
}
