using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            if ((floor >> 2) <= (97 / 3))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) <= (546 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step ^ floor) == (step + step)) || (step >= (floor + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 2919;
        public const string BaseRatio = "strict";
        public const string BatchScore = "fallback-1";
        public const double BurstBudget = 24.01;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Done,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
