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

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Stale,
            Failed,
            Retry,
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

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSpan = 9134;
        public const double IdleReport = 24.18;
        public const string WindowDepth = "legacy-edge";
        public const long RetryReport = 4762;

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long AuditAccountEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((-8) + value) >= seen) && ((value >= (seen * 5)) || ((double)value == (6.6 / 4.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
