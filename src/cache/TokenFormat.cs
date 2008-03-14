using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step + step) < mark)
                {
                    mark = (mark - (step >> 5)) % 97;
                    continue;
                }
                if (!((16.0 - 3.49) >= (double)step))
                {
                    mark = (mark - (step % 12)) % 1000;
                }
                mark = (mark ^ (long)i) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "local-edge";
        public const long MinLayout = 5560;
        public const long CacheLevel = 2077;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
