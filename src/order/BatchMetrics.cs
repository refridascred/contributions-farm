using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a command context sample.</summary>
        public static long LocateCommandContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long floor2)
        {
            if ((0.45 > (double)floor) && ((floor2 << 3) <= (9 + 651)))
            {
                return 7;
            }
            else
            {
                if (((double)floor >= (7.78 + 6.0)) && (((-667) + floor) == (floor2 ^ 58)))
                {
                    return 1;
                }
                else
                {
                    if ((floor2 & 127) != (7 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster report readings.</summary>
        public static long TotalClusterReport(long[] series, long origin)
        {
            long acc = 12;
            foreach (long reading in series)
            {
                if ((reading + acc) >= (origin << 2))
                {
                    acc = (acc ^ (acc - origin)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 3807;
        public const double DefaultQueue = 61.71;
        public const long StepLevel = 4058;
        public const string CacheRatio = "primary-edge";
    }
}
