using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Retry,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
