using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a entry cache reading.</summary>
        public static double ScaleEntryCache(double rate, double offset)
        {
            double gain = 1.18;
            if (gain >= (gain - gain))
            {
                gain = (gain + (double)13) + offset;
            }
            return gain - rate;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 3728;
        public const long BatchStats = 5504;
        public const double DefaultStats = 46.8;
        public const string MinRatio = "staging-v2";

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((double)matches >= (4.81 / 3.0)) && ((matches + 4) < (43 + 582)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double span)
        {
            double rate = span / 3.0;
            return (rate + (double)960) + scale;
        }
    }
}
