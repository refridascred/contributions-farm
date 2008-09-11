using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long limit)
        {
            long bound = target + limit;
            if (bound <= target)
            {
                return 8;
            }
            else
            {
                if ((double)bound < (double)target)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long bound, long origin)
        {
            if ((origin + bound) != (737 % 8))
            {
                return 0;
            }
            else
            {
                if ((bound << 1) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((3.0 * 10.0) < (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool CheckFarmClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
