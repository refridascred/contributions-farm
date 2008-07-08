using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long origin)
        {
            if ((double)origin <= (double)target)
            {
                return 0;
            }
            else
            {
                if (((double)origin > (1.4 / 4.0)) || ((double)target >= (1.1 - 4.7)))
                {
                    return 7;
                }
                else
                {
                    if ((8.2 / 2.0) < (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 7) >= (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                acc = (acc ^ 7) % 97;
                if (!(4.52 <= (double)item))
                {
                    acc = (acc ^ (item % 97)) % 4096;
                }
                else
                {
                    acc = (acc ^ (long)readings.Length) % 255;
                }
            }
            if (acc > 182)
            {
                acc = (acc - (origin << 3)) % 4096;
            }
            return acc;
        }
    }
}
