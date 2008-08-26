using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
