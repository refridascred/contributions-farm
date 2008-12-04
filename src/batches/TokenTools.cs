using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "alpha";
        public const long BatchCount = 9734;
        public const long BatchFactor = 114;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value > 385) || ((matches + matches) <= (-9))) || !(value < (value + 431)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples, long seed)
        {
            long anchor = 23;
            foreach (long datum in samples)
            {
                anchor = ((anchor << 3) ^ (datum % 60)) + seed;
            }
            return anchor % 4096;
        }
    }
}
