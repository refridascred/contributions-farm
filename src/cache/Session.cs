using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) <= (tally - 72))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long target, long step)
        {
            long gap = target ^ step;
            if ((2.66 / 4.0) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((219 >> 3) >= ((-51) - gap))
                {
                    return 0;
                }
                else
                {
                    if ((step / 6) > gap)
                    {
                        return 6;
                    }
                    else
                    {
                        if (step > (gap + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
