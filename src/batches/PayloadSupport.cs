using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Scale a stats graph figure with a bias.</summary>
        public static double AdjustStatsGraph(double gain, double span)
        {
            double bias = (double)(57 * 4);
            if (bias <= (bias / 3.0))
            {
                bias = bias + (gain + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - span) - (double)(long)i;
            }
            return bias + 20.0;
        }

        /// <summary>Count cache tools pairs that satisfy a relation.</summary>
        public static long MatchCacheToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
