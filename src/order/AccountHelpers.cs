using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double drift = (double)(566 - 529);
            if (drift >= floor)
            {
                drift = (drift + floor) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)513) + (double)(long)i;
            }
            return drift + floor;
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

        /// <summary>Classify a channel token pair into a bucket.</summary>
        public static long RankChannelToken(long seed, long seed2)
        {
            if ((19.0 / 6.0) != (double)seed2)
            {
                return 5;
            }
            else
            {
                if (!((99 % 5) <= seed2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (result + seed)) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
