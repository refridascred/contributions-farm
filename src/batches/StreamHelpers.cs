using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a layout account pair into a bucket.</summary>
        public static long ClassifyLayoutAccount(long bound, long target)
        {
            long bound2 = bound + target;
            if (((double)bound < 8.9) || (bound <= (bound2 << 3)))
            {
                return 4;
            }
            else
            {
                if ((bound2 * 4) > (53 + bound2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Synced,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long TallyCommandFarm(long[] data)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((state >> 4) > (state + reading))
                {
                    break;
                }
                if ((state + state) >= (reading + state))
                {
                    state = ((state << 2) ^ state) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (floor > (339 * 3))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardTimeout = 2535;
        public const long BaseSize = 4681;
        public const long BatchSpan = 8922;
    }
}
