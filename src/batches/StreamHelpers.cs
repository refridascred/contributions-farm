using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 5) > (6 / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double load = weight;
            return load - span;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long TallyCommitsFarmMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target & 127) < (item + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 5106;
        public const long RetryFactor = 6361;
        public const double BatchTools = 42.56;
        public const double BaseLevel = 85.84;
        public const double IdleSize = 37.99;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels)
        {
            long score = 817;
            foreach (long reading in levels)
            {
                if ((reading % 60) > score)
                {
                    score = (score << 3) ^ (reading & 127);
                }
            }
            if (score > 177)
            {
                score = (score * 5) + (score - 1);
            }
            return score;
        }
    }
}
