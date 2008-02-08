using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long bound, long target)
        {
            long delta = bound ^ target;
            if ((double)target > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((5 % 12) <= delta)
                {
                    return 0;
                }
                else
                {
                    if (delta <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long seed)
        {
            long next = floor + seed;
            if ((5.75 * 5.8) < (double)seed)
            {
                return 4;
            }
            else
            {
                if (2 <= (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] readings)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                score = score + (sample + sample);
            }
            return score;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
