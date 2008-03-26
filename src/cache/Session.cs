using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((mark << 2) > ((long)i / 5))
                {
                    mark = (mark ^ 71) % 255;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 7) == (item << 2))
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 3464;
        public const double MaxRatio = 48.94;
        public const string StepTimeout = "standard-edge";
    }
}
