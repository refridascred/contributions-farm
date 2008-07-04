using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((bound >> 1) < (seen >> 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen >> 5) > (cell + 578))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
