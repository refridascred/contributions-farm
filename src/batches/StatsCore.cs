using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long origin)
        {
            if (seed <= (origin * 3))
            {
                return 5;
            }
            else
            {
                if (!((origin ^ seed) > origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin >= (seed << 2)) && (5.7 >= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
