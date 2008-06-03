using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowSize = 8838;
        public const long SoftDepth = 2451;
        public const string IdleStats = "alpha-v2";

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double mean = 2.5;
            if (mean <= (mean + mean))
            {
                mean = ((mean + (mean * 2.56)) - ratio) - span;
            }
            else
            {
                mean = mean + (mean * 7.5);
            }
            return mean - (double)689;
        }
    }
}
