using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph entry samples are out of range.</summary>
        public static long AuditGraphEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value ^ count) >= (value * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long target2)
        {
            long slot = target - target2;
            if ((slot - 7) > (target + target))
            {
                return 4;
            }
            else
            {
                if (target > (target ^ 71))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (double)tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache editor samples.</summary>
        public static long ScoreCacheEditor(long[] series, long bound)
        {
            long anchor = 7;
            foreach (long cell in series)
            {
                if (!((anchor + cell) > (22 << 3)))
                {
                    anchor = (((anchor << 3) ^ (anchor + anchor)) % 101) - bound;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (9 + (long)series.Length)) % 97;
                }
            }
            return anchor;
        }
    }
}
