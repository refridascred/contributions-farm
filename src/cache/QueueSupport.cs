using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((score + origin) < (982 + origin))
                {
                    score = (score - score) % 4096;
                    score = score ^ (score << 2);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double ratio = span;
            if (ratio < rate)
            {
                ratio = ratio + (9.06 * 8.7);
            }
            return ratio + (double)59;
        }

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length >= (9.83 / 9.0)) && ((seen >> 2) < 9))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
