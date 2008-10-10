using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 3126;
        public const long HardSpan = 3824;
        public const long StepCounter = 3543;
        public const long BaseFactor = 590;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((double)score <= (8.7 / 6.0)) || (((long)i - score) == (origin + score)))
                {
                    score = score + (long)i;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
