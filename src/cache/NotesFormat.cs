using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MinTimeout = 53.42;
        public const double BatchStats = 27.59;
        public const string BurstDepth = "staging-1";
        public const long WindowSpan = 7940;
        public const long RetryScore = 9612;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (ratio - ratio))
            {
                drift = drift - ratio;
            }
            return drift - offset;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
