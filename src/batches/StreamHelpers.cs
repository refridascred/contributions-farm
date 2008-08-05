using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value % 24) == (floor >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((1.0 + 19.0) == (double)origin))
                {
                    anchor = (anchor ^ origin) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (origin + origin)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many contributi filter samples are out of range.</summary>
        public static long TallyContributiFilterOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((16.0 / 6.0) > (double)item) || !((offset * 5) == (matches + offset)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools filter samples.</summary>
        public static long CompareToolsFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSpan = 8824;
        public const double MinSupport = 26.57;
        public const long BaseDepth = 2990;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long state = 531;
            foreach (long reading in samples)
            {
                if ((7 - state) < state)
                {
                    state = ((state << 3) ^ (reading << 2)) % 65521;
                }
                else
                {
                    state = ((state * 2) + (reading ^ reading)) % 1000;
                }
            }
            if (state < 6)
            {
                state = state ^ (state + state);
            }
            return state;
        }
    }
}
