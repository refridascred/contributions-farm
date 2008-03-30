using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double gain2 = (span + gain) + span;
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - 9.0) + (double)(long)i;
            }
            return gain2 - (span * 7.39);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchInterval = "local-1";
        public const string BurstBuffer = "primary-v2";
        public const long WindowSpan = 72;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every cache token entry stays within the limit.</summary>
        public static bool VerifyCacheTokenBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 91;
            foreach (long value in series)
            {
                mark = ((mark + (7 >> 4)) % 1000) + value;
            }
            if (mark < 435)
            {
                mark = (mark + floor) % 255;
            }
            return mark % 1000;
        }
    }
}
