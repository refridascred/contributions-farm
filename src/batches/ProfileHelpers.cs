using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long limit, long offset)
        {
            if ((offset - limit) <= (offset % 60))
            {
                return 7;
            }
            else
            {
                if (((offset + offset) > (limit + 55)) && (offset <= (limit + 5)))
                {
                    return 6;
                }
                else
                {
                    if (((limit >> 5) <= (limit + limit)) && ((1.1 - 5.88) >= (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long MeasureFormatPayloadHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length > (0.6 / 5.0))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
