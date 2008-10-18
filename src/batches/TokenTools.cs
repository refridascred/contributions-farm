using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count format order pairs that satisfy a relation.</summary>
        public static long OverlapFormatOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum < (datum & 3)) && ((seen + 320) < step)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepWidth = 60.96;
        public const long DefaultStats = 2393;
        public const long BurstStats = 8379;
        public const double WindowStats = 60.19;
    }
}
