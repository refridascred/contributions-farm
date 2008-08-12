using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Idle,
            Stale,
            Active,
            Retry,
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

        /// <summary>Count graph entry pairs that satisfy a relation.</summary>
        public static long PairGraphEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
