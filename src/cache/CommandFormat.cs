using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long AuditGraphCacheHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (long)readings.Length)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every cluster support entry stays within the limit.</summary>
        public static bool VerifyClusterSupportLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = ((state * 4) + (bound * 4)) + (long)i3;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
