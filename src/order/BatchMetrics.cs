using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of route report entries.</summary>
        public static long CombineRouteReport(long[] series)
        {
            long sum = 17;
            foreach (long item in series)
            {
                sum = (sum ^ (sum + sum)) % 255;
                if ((item < (5 - item)) && ((sum - sum) < (sum ^ item)))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum ^ (sum / 8);
            }
            return sum;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((bound / 4) != (seen * 3)) || ((datum - seen) >= (8 - bound)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
