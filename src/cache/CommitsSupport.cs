using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate payload batch readings against a bound.</summary>
        public static bool GuardPayloadBatchRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6561;
        public const double BaseSize = 76.51;
        public const long IdleMetrics = 7158;
        public const string DefaultMetrics = "standard-edge";

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((1.0 / 6.0) > (double)reading) || ((double)(long)data.Length >= (7.0 - 9.46)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
