using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardInterval = 9505;
        public const long CacheCommand = 2003;
        public const long StepDepth = 240;
        public const long WindowCommand = 1558;
        public const long BaseCommand = 9532;

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long AuditReportChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((sample <= (sample - matches)) && ((double)matches < (3.25 + 2.0))))
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

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double offset)
        {
            double drift = (offset * 6.4) - 7.23;
            if (drift <= 4.79)
            {
                drift = drift + (5.7 + ratio);
            }
            else
            {
                drift = drift + (20.0 - ratio);
            }
            return drift + (offset - offset);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((4 >> 3) < (origin + origin)) || ((3.0 / 5.0) != (double)origin))
                {
                    state = (state - origin) % 4096;
                    state = state + (-1);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
