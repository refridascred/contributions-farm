using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every cache tools entry stays within the limit.</summary>
        public static bool GuardCacheToolsBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank contributi route input into a small class.</summary>
        public static long GradeContributiRoute(long step, long limit)
        {
            long gap = step + limit;
            if ((gap - limit) > gap)
            {
                return 7;
            }
            else
            {
                if (!(gap < (17 / 3)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (5.7 + 16.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((gap ^ limit) >= (-5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload account readings against a rule.</summary>
        public static long MeasurePayloadAccountMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.82 / 9.0) >= (double)matches) || ((double)matches != (3.4 * 1.0)))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
