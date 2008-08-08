using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue counter readings.</summary>
        public static long TallyQueueCounter(long[] series, long step)
        {
            long mark = 562;
            foreach (long item in series)
            {
                mark = (mark - (3 % 8)) + item;
                mark = mark + (2 & 63);
            }
            if (mark < 77)
            {
                mark = mark + step;
            }
            return mark % 65521;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long step)
        {
            if ((step - step) != (step + limit))
            {
                return 6;
            }
            else
            {
                if ((step >> 5) > 384)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long floor)
        {
            long gap = offset + floor;
            if ((offset % 16) < gap)
            {
                return 7;
            }
            else
            {
                if (!((double)gap > (9.3 + 4.0)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)floor <= (8.6 + 3.6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if ((target % 5) == (target + 49))
            {
                return 6;
            }
            else
            {
                if ((target + offset) >= (4 - target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum / 5) < (matches << 1))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Synced,
        }
    }
}
