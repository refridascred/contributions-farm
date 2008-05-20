using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "open-v2";
        public const string SoftMetric = "legacy-1";
        public const long BaseMetric = 2761;
        public const string IdleDepth = "cached-1";

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double ratio = 0.2;
            if (ratio < scale)
            {
                ratio = ratio + 5.01;
            }
            return ratio + (bias / 3.0);
        }
    }
}
