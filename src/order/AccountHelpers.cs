using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long TallyCommandToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 4) <= (hits * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
