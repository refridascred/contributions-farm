using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen >= (double)datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double ratio = (double)((-544) >> 4);
            if (ratio > (double)4)
            {
                ratio = (ratio + rate) + offset;
            }
            return ratio + (double)(-77);
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 74;
            foreach (long sample in levels)
            {
                result = (((result ^ result) % 97) ^ sample) + target;
            }
            if (result < 2)
            {
                result = (result - (result & 1)) % 101;
            }
            return result;
        }

        /// <summary>Measure how many batch graph samples are out of range.</summary>
        public static long TallyBatchGraphHits(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + count) != (count / 5))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
