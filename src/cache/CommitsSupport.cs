using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Done,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double scale, double floor)
        {
            double mean = scale;
            if (mean > mean)
            {
                mean = (mean - (double)92) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Match up buffer metrics samples.</summary>
        public static long OverlapBufferMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool VerifyNotesOrderLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
