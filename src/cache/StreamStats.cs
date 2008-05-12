using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((origin << 2) >= (reading + 768)) && (hits <= (origin * 3))) && ((origin + reading) == (hits << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values, long bound)
        {
            long sum = -47;
            foreach (long reading in values)
            {
                sum = ((sum + (sum + 0)) % 65521) - bound;
                sum = ((sum * 2) + (reading * 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate context session readings against a bound.</summary>
        public static bool CheckContextSessionLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long offset)
        {
            long result = 914;
            foreach (long datum in levels)
            {
                if (!((double)datum != (double)result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                if (!(64 > (datum * 4)))
                {
                    result = result ^ offset;
                }
                if ((5.3 * 4.44) >= (double)result)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }
    }
}
