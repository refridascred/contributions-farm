using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long seed)
        {
            long gap = floor + seed;
            if ((7.9 + 6.2) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if (floor < (gap - floor))
                {
                    return 7;
                }
                else
                {
                    if ((358 ^ seed) != (floor >> 3))
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

        /// <summary>Classify a schema account pair into a bucket.</summary>
        public static long SortSchemaAccount(long offset, long target)
        {
            long lane = offset ^ target;
            if ((7.53 <= (double)75) || ((double)target <= (1.9 + 3.3)))
            {
                return 6;
            }
            else
            {
                if (!((476 & 7) >= offset))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ lane) != (1 % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((487 + offset) == (lane << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 41.38;
        public const double MaxQueue = 81.44;
        public const string BurstBudget = "standard-v2";
        public const string LimitQueue = "alpha-1";

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
