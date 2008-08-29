using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= (sample << 1))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally > (3.2 / 5.0))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double gain = (offset * 1.2) - (rate + rate);
            if (gain > gain)
            {
                gain = gain + 6.0;
            }
            return gain + (gain * 18.0);
        }

        /// <summary>Measure how many account graph samples are out of range.</summary>
        public static long TallyAccountGraphHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4 / 3) > (seen << 1))
                {
                    seen = ((seen + 3) + cell) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
