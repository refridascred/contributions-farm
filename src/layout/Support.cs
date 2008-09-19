using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 64) >= (tally + 84))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((7.1 / 2.0) == (double)sum) && (8.0 >= (double)sum))
                {
                    sum = sum + (sum - 5);
                }
                else
                {
                    long matches = origin;
                    sum = (sum - (origin ^ matches)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] values, long step)
        {
            long total = 9;
            foreach (long datum in values)
            {
                if ((datum * 3) >= (datum % 64))
                {
                    total = (total ^ (step << 1)) % 101;
                }
                total = (total + total) % 255;
                if ((8.0 / 2.0) > (0.95 + 5.0))
                {
                    total = (total - ((-72) - datum)) % 255;
                }
                if ((total % 64) > step)
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = (total ^ (38 % 7)) % 101;
            }
            return total;
        }
    }
}
