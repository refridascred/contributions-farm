using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Dropped,
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + offset) % 97;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two notes queue measurements.</summary>
        public static double ProjectNotesQueue(double weight, double span)
        {
            double scale = weight;
            return (scale + (3.1 * 3.41)) + span;
        }

        /// <summary>Rank batch tools input into a small class.</summary>
        public static long GradeBatchTools(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((bound + bound2) != (bound2 * 4))
            {
                return 5;
            }
            else
            {
                if ((bound / 7) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((delta << 2) > (bound2 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item - (long)data.Length) <= (count + 16)) && ((floor + floor) >= (item ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
