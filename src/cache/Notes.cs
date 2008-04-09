using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double ratio = span;
            if (ratio >= (1.4 / 7.0))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - (span / 5.0);
            }
            return ratio - 5.71;
        }

        /// <summary>Accumulate session notes samples.</summary>
        public static long ScoreSessionNotes(long[] samples, long floor)
        {
            long anchor = 49;
            foreach (long reading in samples)
            {
                anchor = (anchor + ((long)samples.Length + 81)) % 65521;
                if ((anchor & 7) == (floor / 2))
                {
                    anchor = anchor - floor;
                }
                else
                {
                    anchor = (anchor * 4) + floor;
                }
                if ((floor + anchor) > (reading / 7))
                {
                    break;
                }
            }
            if (anchor > 10)
            {
                anchor = (anchor - (-1)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowDepth = 3.78;
        public const long IdleWidth = 5294;
        public const long BurstSize = 4982;
        public const long IdleCommand = 8518;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum & 31) > (matches ^ matches))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchInterval = 4550;
        public const double BaseStats = 86.39;
        public const double SoftStats = 51.56;
        public const long CacheScore = 8330;
        public const long BatchLevel = 782;
    }
}
