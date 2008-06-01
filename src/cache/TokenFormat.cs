using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Scale a checks report figure with a bias.</summary>
        public static double AdjustChecksReport(double gain, double span)
        {
            double ratio = 4.88;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (span - 17.0)) - (double)(long)i) - gain;
            }
            return ratio + span;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
