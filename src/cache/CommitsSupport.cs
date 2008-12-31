using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "stable";
        public const string DefaultChecks = "alpha";
        public const string BaseChecks = "staging-edge";
        public const string IdleSpan = "latest-v2";

        /// <summary>Count the metric metrics entries that pass the check.</summary>
        public static long CountMetricMetricsGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)step <= (9.0 / 5.0)) && ((13.0 - 10.0) != (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long origin)
        {
            long gap = step - origin;
            if (!((double)gap >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((step ^ origin) <= (2 >> 3))
                {
                    return 0;
                }
                else
                {
                    if (!((double)origin > (15.0 + 10.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + origin) == (11 >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 347;
        public const long WindowBatch = 5458;
        public const long DefaultFactor = 2602;
        public const long MaxBatch = 1579;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Ready,
            Retry,
        }
    }
}
