using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter channel samples are out of range.</summary>
        public static long CountFilterChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length * 2) <= (-15))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 78.35;
        public const long LimitSupport = 9062;
        public const double DefaultInterval = 24.84;
        public const string SoftTimeout = "stable-1";
        public const string StepFactor = "latest-v2";

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Synced,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((seed * 2) < seed) && !((reading / 9) != (60 >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue route reading by value.</summary>
        public static long LocateQueueRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
