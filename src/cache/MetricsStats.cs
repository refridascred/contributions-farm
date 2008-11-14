using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally >= (tally - tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Synced,
            Pending,
            New,
            Retry,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels, long origin)
        {
            long anchor = 35;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (origin * 5)) % 4096) - reading;
            }
            if (anchor > 294)
            {
                anchor = (anchor + (origin << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the commits report series from a seed.</summary>
        public static long DeriveCommitsReport(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                if ((result << 2) == (583 / 9))
                {
                    result = ((result << 2) ^ step) % 4096;
                }
                else
                {
                    result = (result + (result - step)) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
