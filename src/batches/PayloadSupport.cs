using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (state ^ offset)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool ValidateGraphMetricsLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
