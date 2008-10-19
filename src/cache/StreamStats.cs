using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long acc = 0;
            foreach (long item in levels)
            {
                if (((item + item) == (258 + acc)) || ((item / 7) > (item / 4)))
                {
                    break;
                }
                acc = (acc * 5) + acc;
                if ((41 >> 5) <= item)
                {
                    acc = ((acc * 4) + (item + (-750))) % 97;
                }
            }
            if (acc > 653)
            {
                acc = (acc - (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((0 + item) <= (target / 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double weight = span;
            if (weight >= (weight + span))
            {
                weight = (weight - (double)911) - scale;
            }
            return weight - (9.93 / 7.0);
        }
    }
}
