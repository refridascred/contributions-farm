using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (double)724)
            {
                ratio = ratio + (bias * 1.7);
            }
            return ratio - scale;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((83 * 2) == (datum ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double scale = gain + gain;
            if (scale > (double)490)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (1.08 / 6.0);
            }
            return scale - span;
        }
    }
}
