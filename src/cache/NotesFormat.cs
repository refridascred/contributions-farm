using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Derive the next graph account value from a seed.</summary>
        public static long SeriesGraphAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + 584) % 4096;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next cluster window value.</summary>
        public static double ProjectClusterWindow(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (floor + 7.0))
            {
                drift = drift + ratio;
            }
            else
            {
                drift = drift - (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 3.49) + (double)(long)i;
            }
            return drift - ratio;
        }
    }
}
