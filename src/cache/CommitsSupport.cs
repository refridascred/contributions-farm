using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)item > (4.2 * 4.2)) && (item < step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((seen + 8) > (datum + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long result = 22;
            foreach (long datum in series)
            {
                if ((74 ^ result) >= 306)
                {
                    result = result - datum;
                }
                else
                {
                    result = ((result << 2) ^ (target - result)) % 97;
                }
                if ((1.19 / 3.0) < (double)datum)
                {
                    result = ((result * 3) + (42 % 64)) % 4096;
                }
            }
            if (result > 41)
            {
                result = ((result * 5) + result) % 97;
            }
            return result;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Failed,
            Synced,
            New,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Paused,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = state + (state & 3);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
