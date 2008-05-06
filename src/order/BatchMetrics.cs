using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Ready,
            New,
            Paused,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter contributi readings against a rule.</summary>
        public static long MeasureFilterContributiOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((limit ^ limit) <= (-6)) && ((limit % 7) == (item >> 5))) && ((limit + limit) >= (item ^ 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 16.26;
        public const long IdleChannel = 5475;
        public const long MaxChannel = 6431;
        public const string BatchDepth = "standard-1";
    }
}
