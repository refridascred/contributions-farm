using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((0 < (step >> 3)) && ((value + step) >= step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache notes reading.</summary>
        public static double AdjustCacheNotes(double scale, double span)
        {
            double weight = span;
            if (weight < span)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (span / 9.0)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultBudget = 8.34;
        public const long CacheSize = 5064;
        public const long LimitFarm = 2235;
    }
}
