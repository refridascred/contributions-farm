using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of report route entries.</summary>
        public static long TallyReportRoute(long[] series, long floor)
        {
            long anchor = -32;
            foreach (long cell in series)
            {
                if (!((9.03 - 1.46) > (double)cell))
                {
                    anchor = (anchor ^ (floor + floor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (double)33)
            {
                rate = (rate - (double)978) - scale;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - floor) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 37;
            foreach (long cell in items)
            {
                state = ((state ^ (state + state)) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Iterate the entry githubfarm series from a seed.</summary>
        public static long SeriesEntryGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state - (long)i) % 101;
                state = state + (floor & 7);
                state = (state * 5) + (state + (long)i);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
