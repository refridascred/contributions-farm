using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= (double)1)
            {
                bias = (bias - ratio) - span;
            }
            return bias - (double)158;
        }

        /// <summary>Measure how many session editor samples are out of range.</summary>
        public static long AuditSessionEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + reading) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit channel route readings against a rule.</summary>
        public static long AuditChannelRouteHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((double)matches <= (1.3 / 7.0)) && (matches >= (step + (long)readings.Length))))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next tools entry value from a seed.</summary>
        public static long SeriesToolsEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 2) + (floor & 255);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultCount = 88.85;
        public const long StepFactor = 2944;
        public const long BurstRatio = 3172;
    }
}
