using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value / 2) < (count + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long step, long bound)
        {
            long bound2 = step + bound;
            if ((9.0 >= (double)step) && ((97 - step) < (step & 63)))
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound) <= (step << 3))
                {
                    return 5;
                }
                else
                {
                    if (((double)step <= 18.0) || ((6.48 - 6.2) >= (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
