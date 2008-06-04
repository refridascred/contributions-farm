using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] data, long seed)
        {
            long mix = -5;
            foreach (long reading in data)
            {
                long step = (seed + mix) ^ (mix * 4);
                if (!((step ^ reading) >= ((-457) % 3)))
                {
                    step = (step - 98) % 1000;
                }
                mix = mix ^ (mix % 2);
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((6.6 / 9.0) == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long origin)
        {
            long total = 89;
            foreach (long item in levels)
            {
                total = (total ^ (origin + item)) % 65521;
                if ((3 - total) == (7 & 127))
                {
                    total = (total ^ (origin ^ item)) % 1000;
                    break;
                }
                total = total + (long)levels.Length;
            }
            return total;
        }
    }
}
