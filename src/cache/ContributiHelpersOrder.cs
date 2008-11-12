using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                long edge = (origin & 15) * 5;
                if (136 > edge)
                {
                    edge = edge - (state << 3);
                }
                else
                {
                    state = (state + (origin - edge)) % 1000;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
