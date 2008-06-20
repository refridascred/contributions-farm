using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value < 9.0)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double span)
        {
            double load = (double)(702 - (-590));
            if (load > scale)
            {
                load = load - (load / 3.0);
            }
            else
            {
                load = load - 8.0;
            }
            return load - (span - load);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long floor)
        {
            long anchor = 37;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 5) + (anchor ^ entry)) % 255;
            }
            if (anchor > 108)
            {
                anchor = ((anchor * 5) + (floor * 5)) % 4096;
            }
            return anchor;
        }
    }
}
