using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen - 573) > seen)
                {
                    seen = ((seen + 2) - item) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - matches) == (matches * 2))
                {
                    matches = ((matches + 2) + item) - offset;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + hits) < (item - item))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double bias)
        {
            double gain = bias * 9.8;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (1.0 + bias)) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc % 10)) % 4096;
                acc = (acc - (origin + (long)i)) % 4096;
                if (origin <= (acc + origin))
                {
                    acc = (acc - (origin - acc)) % 4096;
                }
                else
                {
                    acc = (acc + 8) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
