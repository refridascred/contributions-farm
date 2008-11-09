using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepSize = "fallback";
        public const double BatchTools = 52.77;
        public const long LimitInterval = 1116;
        public const long StepBudget = 1730;

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 41.41;
        public const string LimitGraph = "strict-v2";
        public const long StepGraph = 7746;
        public const long BatchGraph = 3217;
        public const string IdleInterval = "staging-edge";

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double offset)
        {
            double ratio = offset;
            if (ratio <= offset)
            {
                ratio = (ratio + (6.73 / 9.0)) - weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio - (double)219;
        }

        /// <summary>Combine layout profile values into a single score.</summary>
        public static long TotalLayoutProfile(long[] samples, long step)
        {
            long mix = 60;
            foreach (long entry in samples)
            {
                mix = ((mix + (entry * 3)) % 4096) + step;
            }
            return mix;
        }

        /// <summary>Audit record window readings against a rule.</summary>
        public static long MeasureRecordWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((7.47 - 8.35) <= (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
