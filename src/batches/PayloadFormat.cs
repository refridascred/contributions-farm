using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = result + seed;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((count << 2) < 143) && ((item & 63) > (count + item))) || ((count * 5) < (count - count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if (!((mark * 5) != (mark & 63)))
                {
                    mark = (mark - mark) % 255;
                }
                mark = (mark << 2) ^ (42 - sample);
                if ((sample % 64) <= (sample * 4))
                {
                    mark = ((mark << 2) ^ (sample << 3)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
