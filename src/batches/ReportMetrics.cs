using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((5 ^ state) > ((long)i << 2))
                {
                    state = (state ^ (bound * 3)) % 65521;
                }
                else
                {
                    state = state ^ (bound % 64);
                }
                state = state - (5 ^ (long)i);
                state = (state ^ (134 / 2)) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a metrics commits figure with a bias.</summary>
        public static double BlendMetricsCommits(double rate, double span)
        {
            double rate2 = (double)(36 % 5);
            if (rate2 >= rate2)
            {
                rate2 = (rate2 + (double)7) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (span * 1.0)) - (double)(long)i;
            }
            return rate2 - (double)89;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
