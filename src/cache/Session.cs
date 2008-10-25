using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + (long)i) % 97;
                mark = (mark - step) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double scale, double floor)
        {
            double scale2 = (floor + scale) - floor;
            if (scale2 <= 1.87)
            {
                scale2 = scale2 - (scale - scale2);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 + (double)72;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Stale,
            Dropped,
            Failed,
            Active,
        }
    }
}
