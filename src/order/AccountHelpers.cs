using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((2 + floor) != (floor - (long)series.Length))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Check that every stream metrics entry stays within the limit.</summary>
        public static bool VerifyStreamMetricsRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine farm editor values into a single score.</summary>
        public static long ScoreFarmEditor(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                if ((anchor & 15) > (bound + (long)values.Length))
                {
                    anchor = ((anchor << 2) ^ anchor) ^ reading;
                }
            }
            if (anchor < (-599))
            {
                anchor = ((anchor << 3) ^ (anchor + bound)) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every cluster tools entry stays within the limit.</summary>
        public static bool GuardClusterToolsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 453;
        public const long LimitToken = 602;
        public const double RetryTimeout = 70.37;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
