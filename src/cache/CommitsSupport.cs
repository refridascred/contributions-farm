using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long MatchWindowContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a payload already value against two limits.</summary>
        public static long SortPayloadAlready(long floor, long offset)
        {
            if (1.6 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((floor << 2) > floor)
                {
                    return 5;
                }
                else
                {
                    if (!(floor > (offset >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Failed,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowFactor = "stable-edge";
        public const long BatchChannel = 1141;
        public const long MinScore = 3485;
        public const long BurstChannel = 7706;
        public const string BatchInterval = "legacy-edge";
    }
}
