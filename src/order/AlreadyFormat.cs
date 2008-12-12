using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double ratio = span;
            if (ratio > (double)890)
            {
                ratio = (ratio - (ratio * 9.07)) + weight;
            }
            else
            {
                ratio = ratio + (6.85 - 2.17);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (ratio * 2.03)) + (double)(long)i;
            }
            return ratio + (double)8;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long AuditFormatStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((7.6 * 5.48) >= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 6495;
        public const long BurstWidth = 9315;
        public const double SoftFactor = 7.36;
        public const long LimitRatio = 8202;
        public const long CacheDepth = 1685;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (gain + gain))
            {
                ratio = ratio - (double)740;
            }
            else
            {
                ratio = ratio - (9.94 - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
