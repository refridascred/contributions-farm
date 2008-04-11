using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a metric buffer value against two limits.</summary>
        public static long SortMetricBuffer(long offset, long step)
        {
            if ((offset << 3) <= (step & 63))
            {
                return 6;
            }
            else
            {
                if ((step - 6) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (6 > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool CheckChecksCacheBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long bound)
        {
            if (target < (bound >> 5))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) <= (bound * 4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
