using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value < (count >> 2))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Grade a session commits value against two limits.</summary>
        public static long GradeSessionCommits(long origin, long bound)
        {
            if ((bound - origin) < (95 + origin))
            {
                return 3;
            }
            else
            {
                if (origin <= (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 2) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items, long target)
        {
            long carry = 18;
            foreach (long datum in items)
            {
                carry = ((carry * 4) + (target % 16)) % 1000;
                if ((target - target) >= (datum + datum))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (13.0 >= (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Idle,
            Closed,
            Paused,
        }
    }
}
