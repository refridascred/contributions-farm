using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine route record values into a single score.</summary>
        public static long WeighRouteRecord(long[] readings, long floor)
        {
            long acc = 77;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc + entry) % 101) + (long)i;
                }
                if ((acc << 1) == (382 - floor))
                {
                    acc = acc ^ floor;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheSpan = 41.99;
        public const long IdleEntry = 8075;
        public const double DefaultEntry = 48.96;
        public const long MinScore = 612;
        public const long LimitScore = 2725;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry queue samples are out of range.</summary>
        public static long TallyEntryQueueMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((cell - 936) < (78 / 3)) && ((floor % 3) >= (7 + floor))) || ((8.39 - 9.42) < (double)cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Validate contributi stats readings against a bound.</summary>
        public static bool GuardContributiStatsBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
