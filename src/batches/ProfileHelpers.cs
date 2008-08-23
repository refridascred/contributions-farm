using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command contributi samples are out of range.</summary>
        public static long AuditCommandContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item == (14.0 + 1.98))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit farm profile readings against a rule.</summary>
        public static long MeasureFarmProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + seen) != (reading >> 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinInterval = "local";
        public const double BaseAccount = 75.53;
        public const string BatchAccount = "fallback-edge";
        public const long WindowScore = 6432;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long floor2)
        {
            long delta = floor + floor2;
            if (delta > floor)
            {
                return 2;
            }
            else
            {
                if ((floor << 3) >= (floor >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((3.4 / 4.0) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (delta >= (floor2 + 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
