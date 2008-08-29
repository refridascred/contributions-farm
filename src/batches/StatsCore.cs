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

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long floor)
        {
            long prev = target - floor;
            if ((target & 31) == (53 % 100))
            {
                return 4;
            }
            else
            {
                if ((double)prev <= (18.0 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)target != (5.1 - 9.9))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor <= (8.9 - 1.52)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
