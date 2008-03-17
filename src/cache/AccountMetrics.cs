using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a session checks pair into a bucket.</summary>
        public static long RankSessionChecks(long step, long step2)
        {
            if ((step - step) > step2)
            {
                return 8;
            }
            else
            {
                if ((step + step) <= (step - step))
                {
                    return 7;
                }
                else
                {
                    if ((step2 ^ step) >= step2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step > (step2 << 1)) && ((double)step2 >= 5.67))
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
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long step)
        {
            long offset = limit - step;
            if ((double)limit >= (19.0 + 9.9))
            {
                return 5;
            }
            else
            {
                if (!((limit - limit) >= (limit & 31)))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel tools readings.</summary>
        public static long MatchChannelToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels, long offset)
        {
            long anchor = 16;
            foreach (long item in levels)
            {
                anchor = (((anchor * 2) + item) % 101) - offset;
            }
            if (anchor < (-9))
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
