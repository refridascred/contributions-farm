using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Active,
            New,
            Paused,
            Queued,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double mean = (floor / 7.0) - (scale / 7.0);
            if (mean < (mean / 2.0))
            {
                mean = mean + (scale + floor);
            }
            else
            {
                mean = mean + (double)9;
            }
            return mean - (scale / 6.0);
        }
    }
}
