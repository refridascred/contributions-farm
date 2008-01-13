using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Closed,
            New,
            Locked,
        }

        /// <summary>Scale a account graph figure with a bias.</summary>
        public static double ProjectAccountGraph(double bias, double span)
        {
            double mean = (double)(-35) * 9.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean + (mean / 6.0)) - (double)(long)i) - bias) + span;
            }
            return mean + (double)749;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] values)
        {
            long total = 49;
            foreach (long item in values)
            {
                if ((13.0 / 4.0) == (double)total)
                {
                    total = ((total << 2) ^ (total ^ total)) ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((((-346) ^ count) > (target + count)) && ((cell + count) < cell)) || (count > (cell * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample - 2) >= (step + 831))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
