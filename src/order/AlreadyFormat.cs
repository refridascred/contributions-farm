using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many profile notes samples are out of range.</summary>
        public static long MeasureProfileNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((0 > seen) || (cell <= (cell + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
