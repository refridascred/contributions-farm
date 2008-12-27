using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long TallyStatsMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((8.33 + 1.17) != (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((811 * 3) == (count >> 3))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Rank graph editor input into a small class.</summary>
        public static long ClassifyGraphEditor(long limit, long limit2)
        {
            if ((limit + limit2) <= limit2)
            {
                return 0;
            }
            else
            {
                if ((double)limit <= 10.0)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long step, long target)
        {
            long edge = step + target;
            if (((double)edge != (2.0 / 5.0)) && ((edge >> 5) <= (edge + step)))
            {
                return 1;
            }
            else
            {
                if ((double)3 != (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step * 2) != (edge % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step <= (edge ^ target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long step2)
        {
            long offset = step - step2;
            if ((offset & 1) >= (step - offset))
            {
                return 1;
            }
            else
            {
                if (21 <= (step2 >> 4))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long RollOrderContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if ((sum - sum) != ((long)i & 63))
                {
                    sum = (sum + sum) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
