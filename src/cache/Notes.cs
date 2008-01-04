using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry < (entry + 876)) && ((12.0 / 8.0) != (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema farm entry stays within the limit.</summary>
        public static bool ValidateSchemaFarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Dropped,
            Locked,
            Idle,
        }
    }
}
