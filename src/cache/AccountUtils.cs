using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = (scale - floor) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.9 / 2.0)) + (double)(long)i;
            }
            return scale + (double)61;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Queued,
            Ready,
            Idle,
            Active,
        }
    }
}
