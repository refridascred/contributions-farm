using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = weight + (floor * 1.18);
            }
            return weight - (floor - floor);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Stale,
            Failed,
            Queued,
            Paused,
        }
    }
}
