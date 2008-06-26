using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a entry session reading.</summary>
        public static double AdjustEntrySession(double ratio, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = gain + (ratio * 8.66);
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (ratio * 1.89)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            New,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Idle,
            Done,
        }
    }
}
