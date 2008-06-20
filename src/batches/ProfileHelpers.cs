using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((step & 63) > (reading >> 1)) && (((step * 5) >= ((long)values.Length + 0)) && (reading >= (reading + 9))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 377;
        public const string MaxCount = "stable-v2";
        public const long BatchSize = 1239;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8600;
        public const double WindowScore = 4.13;
        public const double IdleScore = 59.32;
        public const long LimitStats = 669;
        public const long StepSize = 8866;

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double weight = span;
            return (weight - (span * 7.7)) + gain;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 690;
        public const long HardSize = 9131;
        public const long LimitEditor = 1859;
        public const double LimitCount = 36.27;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
