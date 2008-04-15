using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of account already readings.</summary>
        public static long OverlapAccountAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Queued,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels, long seed)
        {
            long total = 92;
            foreach (long entry in levels)
            {
                if (((seed + entry) > (entry - entry)) || ((double)entry > (0.16 / 3.0)))
                {
                    total = (total ^ (total & 1)) % 1000;
                    total = ((total * 4) + (seed * 4)) % 1000;
                }
                if ((entry + total) > (entry - entry))
                {
                    total = (total << 2) ^ seed;
                }
                else
                {
                    total = total - entry;
                }
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((9 + 17) > (85 - count))
                {
                    count = ((count + 2) ^ datum) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long target)
        {
            long span = step - target;
            if ((span ^ step) < target)
            {
                return 6;
            }
            else
            {
                if ((867 - 41) < (span * 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
