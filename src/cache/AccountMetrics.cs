using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] levels, long origin)
        {
            long state = 637;
            foreach (long sample in levels)
            {
                if ((state + state) == (sample + origin))
                {
                    state = ((state << 2) ^ (sample - state)) % 4096;
                }
                else
                {
                    state = (state + (306 - state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels, long step)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if ((step + item) > (step ^ mark))
                {
                    mark = ((mark * 2) + (item + step)) % 4096;
                }
                if ((item + mark) == (item - step))
                {
                    mark = (mark - (453 - mark)) % 1000;
                }
                else
                {
                    mark = mark - 957;
                }
            }
            return mark;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings, long step)
        {
            long mark = 454;
            foreach (long datum in readings)
            {
                if ((6 - datum) == (datum >> 2))
                {
                    mark = ((mark * 2) + (datum + step)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long limit)
        {
            if (((-545) ^ limit) > (limit << 3))
            {
                return 3;
            }
            else
            {
                if (limit < 5)
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 5) == (limit + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Ready,
            Synced,
            Dropped,
        }
    }
}
