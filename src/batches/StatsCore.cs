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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((19 / 2) == (matches - 2))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
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

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double mean = (double)(240 + 271);
            if (mean < (ratio * 19.0))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (double)72;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)657) + (double)(long)i;
            }
            return mean - (bias + ratio);
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
