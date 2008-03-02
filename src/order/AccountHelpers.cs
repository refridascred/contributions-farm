using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double drift = (offset + weight) / 6.0;
            if (drift < (double)9)
            {
                drift = drift + (weight * 7.2);
            }
            else
            {
                drift = drift + 7.3;
            }
            return drift + 0.87;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count % 10) >= (count / 6))
                {
                    count = ((count + 3) ^ item) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the format report series from a seed.</summary>
        public static long IterateFormatReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin >= mix) && ((28 + mix) != (long)i))
                {
                    mix = (mix + 652) % 101;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 2) ^ (limit % 97);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many order counter samples are out of range.</summary>
        public static long AuditOrderCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (8.62 + 0.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
