using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3.0 / 5.0) > (double)matches)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 9811;
        public const string CacheCount = "staging-edge";
        public const long DefaultRatio = 5289;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum * 3) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
