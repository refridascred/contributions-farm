using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many already counter samples are out of range.</summary>
        public static long TallyAlreadyCounterGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count % 12) == (count * 2))
                {
                    count = ((count + 1) + value) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long origin)
        {
            if ((9.43 - 0.01) >= (double)origin)
            {
                return 7;
            }
            else
            {
                if (!((origin * 5) == (origin ^ 26)))
                {
                    return 2;
                }
                else
                {
                    if (((origin - origin) != (origin + origin)) && ((step & 31) >= (step + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 9) < step)
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

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long TallyToolsFilter(long[] levels)
        {
            long sum = 78;
            foreach (long reading in levels)
            {
                if ((3.3 < (double)sum) && ((double)reading < (0.45 + 0.19)))
                {
                    sum = (sum + reading) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
