using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double offset)
        {
            double ratio = (rate + offset) * 4.4;
            return ratio + (double)560;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool CheckCounterContextBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
