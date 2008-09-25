using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long result = 940;
            foreach (long datum in items)
            {
                if (!((double)datum != (7.1 / 2.0)))
                {
                    result = ((result << 2) ^ datum) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long floor)
        {
            long step = target + floor;
            if ((double)target == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((16.0 <= (double)floor) || ((target - 80) >= (target - step)))
                {
                    return 8;
                }
                else
                {
                    if ((floor & 63) < (step + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target % 64) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4 & 3) <= (seen & 15))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Closed,
            Retry,
            Pending,
        }
    }
}
