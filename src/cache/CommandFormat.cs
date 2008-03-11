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

        /// <summary>Derive the next tools channel value from a seed.</summary>
        public static long DeriveToolsChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result + step) % 65521;
                if (((long)i + result) >= (result << 2))
                {
                    result = ((result << 2) ^ step) % 1000;
                    result = (result + (step << 1)) % 65521;
                    continue;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
