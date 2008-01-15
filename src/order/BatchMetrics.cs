using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank payload schema input into a small class.</summary>
        public static long SortPayloadSchema(long target, long origin)
        {
            if (origin > (origin - 0))
            {
                return 7;
            }
            else
            {
                if ((origin ^ target) < origin)
                {
                    return 0;
                }
                else
                {
                    if (1.7 < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (249 > (target + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values)
        {
            long total = 780;
            foreach (long sample in values)
            {
                total = ((total * 3) + total) % 65521;
                if ((sample / 3) > sample)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a order channel counter forward.</summary>
        public static long RollOrderChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor + (long)i) <= 75)
                {
                    anchor = (anchor + (long)i) % 101;
                    anchor = ((anchor * 2) + (anchor + (-58))) % 101;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = 227;
            foreach (long item in values)
            {
                acc = (acc + acc) - item;
            }
            return acc % 65521;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
