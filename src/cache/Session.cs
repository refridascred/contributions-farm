using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a commits metric counter forward.</summary>
        public static long IterateCommitsMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)6 != (double)seed)
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + ((long)i & 127)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((44 * 2) != (datum / 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
        }
    }
}
