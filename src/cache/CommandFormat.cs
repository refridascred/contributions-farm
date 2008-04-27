using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheRatio = 38.48;
        public const long BaseReport = 322;
        public const double DefaultDepth = 76.98;
        public const long RetryScore = 8937;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Locked,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)reading > (6.6 * 12.0)) && (17 >= reading))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
