using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many report editor samples are out of range.</summary>
        public static long MeasureReportEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample % 16) < sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Total { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
