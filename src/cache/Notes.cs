using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double load = scale;
            if (load <= scale)
            {
                load = load + offset;
            }
            return load - (double)807;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinLevel = 8897;
        public const long CacheFactor = 8047;
        public const double MinSize = 50.09;
        public const double MaxTimeout = 24.14;

        /// <summary>Project the next entry schema value.</summary>
        public static double BlendEntrySchema(double scale, double span)
        {
            double drift = span;
            return (drift - (span / 8.0)) + scale;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry & 3) != (matches / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Ready,
            Closed,
            Draft,
        }
    }
}
