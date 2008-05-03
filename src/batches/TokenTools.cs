using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long bound)
        {
            if (((double)bound == (2.87 * 9.0)) && ((39 + 94) == (origin * 4)))
            {
                return 3;
            }
            else
            {
                if ((8.7 / 8.0) < (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long TallyChecksQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((13.0 * 18.0) < (double)reading) && ((9 << 2) <= (seen % 97)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data, long offset)
        {
            long acc = -960;
            foreach (long value in data)
            {
                acc = ((acc + (offset << 3)) % 65521) + value;
                if (((long)data.Length < acc) && ((double)73 == (double)acc))
                {
                    break;
                }
            }
            if (acc > (-874))
            {
                acc = (acc + (acc - offset)) % 1000;
            }
            return acc;
        }
    }
}
